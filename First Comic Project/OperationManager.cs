using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_Comic_Project
{
    class OperationManager
    {
        private Form1 form;
        public OperationManager(Form1 form)
        {
            this.form = form;
        }

        public void startOperation(IEnumerable<int> episodes)
        {
            Thread thread = new Thread(new ThreadStart(() => processBulk(episodes)));
            thread.Start();
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
                }
                catch (Exception e)
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

                buttonStart.Enabled = true;
                Cursor = Cursors.Default;
            });
            setLabel("");

            SystemSounds.Beep.Play();
            Process.Start(getExportPath());
        }
    }
}
