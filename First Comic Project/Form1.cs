using First_Comic_Project.Controls.Episode;
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

        public UserControl episodeSelection;

        public Form1()
        {
            InitializeComponent();
            instance = this;
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

        #region Process Episodes
        void startOperation()
        {
            IEnumerable<int> episodes = ((EpisodeSelection)episodeSelection).getEpisodes();

            if (episodes != null)
            {
                Cursor = Cursors.WaitCursor;
                buttonProcessBulk.Enabled = false;

                progressBar.Maximum = episodes.Count();

                Thread thread = new Thread(new ThreadStart(() => processBulk(episodes)));
                thread.Start();
            }
        }

        void processBulk(IEnumerable<int> episodes)
        {

            // For each episode
            foreach (int i in episodes)
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
                    Debug.WriteLine("Failed episode " + i + ": " + e.StackTrace);
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
        #endregion

        void setEpisodeControl(UserControl control)
        {
            if (!(control is EpisodeSelection))
            {
                throw new Exception("Control is not an episode selection.");
            }

            // If an item is present, remove it.
            if (episodeSelection != null)
            {
                gatheringGroupBox.Controls.Remove(episodeSelection);
            }

            gatheringGroupBox.Controls.Add(control);
            control.Location = new Point(3, 43);

            episodeSelection = control;
        }

        private void episodeSelectionMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (episodeSelectionMode.SelectedIndex)
            {
                case 0:
                    setEpisodeControl(new ControlRange());
                    break;

                case 1:
                    setEpisodeControl(new ControlSingle());
                    break;
            }
        }

        void setupGatheringBox()
        {
            episodeSelectionMode.SelectedIndex = 0;
            setEpisodeControl(new ControlRange());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setupGatheringBox();
        }
    }
}
