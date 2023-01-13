using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_Comic_Project
{
    public partial class Form1 : Form
    {
        OpenFileDialog open = new OpenFileDialog();
        public static Form1 instance;

        public Form1()
        {
            InitializeComponent();
            instance = this;
        }

        void saveImage(Image image)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "PNG File (*.png)|*.png";

            if (save.ShowDialog() == DialogResult.OK)
            {
                image.Save(save.FileName);
            }
        }

        string getExportFolder()
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.SelectedPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            folder.Description = "Export Folder";

            if (folder.ShowDialog() == DialogResult.OK)
            {
                string path = folder.SelectedPath;
                return path;
            }

            return null;
        }

        string getExportPath()
        {
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Export");

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            return path;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            startOperation();
        }

        void setLabel(string text)
        {
            BeginInvoke((MethodInvoker)delegate ()
            {
                labelProgress.Text = text;
            });
        }

        void processBulk()
        {
            int episodeQuantity = (int)spinnerEpisodeEnd.Value - (int)spinnerEpisodeStart.Value;

            // For each episode
            for (int i = (int)spinnerEpisodeStart.Value; i <= spinnerEpisodeEnd.Value; i++)
            {
                try
                {
                    setLabel("Gathering Episode #" + i);

                    Image episode = Gatherer.getComic(i);

                    if (episode == null)
                    {
                        continue;
                    }

                    episode.Save(Path.Combine(getExportPath(), "Episode #" + i + ".png"));

                    if (checkBoxSeparate.Checked)
                    {
                        setLabel("Separating the panels for Episode #" + i);

                        string episodeDirectory = Path.Combine(getExportPath(), "Episode #" + i);

                        if (!Directory.Exists(episodeDirectory))
                        {
                            Directory.CreateDirectory(episodeDirectory);
                        }

                        //Separator.separateAndExportPanels(episode, colorDialog1.Color, Path.Combine(episodeDirectory, "Panel #{id}.png"));

                        List<Image> images = Separator.separatePanels(episode, colorDialog1.Color);

                        int x = 0;
                        foreach (Image panel in images)
                        {
                            panel.Save(Path.Combine(episodeDirectory, "Panel #" + x + ".png"));
                            panel.Dispose();
                            x++;
                        }
                        episode.Dispose();
                    }

                    BeginInvoke((MethodInvoker)delegate ()
                    {
                        progressBar.Value++;
                    });
                }catch (Exception e)
                {
                    string episodeDirectory = Path.Combine(getExportPath(), "Episode #" + i);

                    if (!Directory.Exists(episodeDirectory))
                    {
                        Directory.CreateDirectory(episodeDirectory);
                    }
                }
            }

            BeginInvoke((MethodInvoker)delegate ()
            {
                progressBar.Value = 0;

                buttonProcessBulk.Enabled = true;
                Cursor = Cursors.Default;
            });
            setLabel("");

            SystemSounds.Beep.Play();
            Process.Start(getExportPath());
        }

        /*
         * Operation Management
         */
        void startOperation()
        {
            if (spinnerEpisodeStart.Value > spinnerEpisodeEnd.Value)
            {
                MessageBox.Show("The start episode is higher than the end episode.");
                return;
            }

            Cursor = Cursors.WaitCursor;
            buttonProcessBulk.Enabled = false;

            int episodeQuantity = (int)spinnerEpisodeEnd.Value - (int)spinnerEpisodeStart.Value;
            progressBar.Maximum = episodeQuantity + 1;

            Thread thread = new Thread(new ThreadStart(processBulk));
            thread.Start();
        }
    }
}
