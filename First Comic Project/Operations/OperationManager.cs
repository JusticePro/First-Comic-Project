using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_Comic_Project.Operations
{
    class OperationManager
    {
        private Form1 form;
        public OperationManager(Form1 form)
        {
            this.form = form;
        }

        public void startOperation(IEnumerable<int> episodes, bool doSeparate)
        {
            Thread thread = new Thread(new ThreadStart(() => processBulk(episodes, doSeparate)));
            thread.Start();
        }

        /// <summary>
        /// This is the path to the export folder. If one doesn't exist, it will be created.
        /// The export folder will be in the same folder as the executable.
        /// [Folder of Executable]/Export
        /// </summary>
        /// <returns>Path to export folder.</returns>
        string getExportPath()
        {
            // Path is "<Folder of Executable>/Export"
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Export");

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            return path;
        }

        Image downloadEpisode(int episodeId)
        {
            Image episode = Gatherer.getComic(episodeId);

            if (episode == null)
            {
                return null;
            }

            episode.Save(Path.Combine(getExportPath(), "Episode #" + episodeId + ".png"));
            return episode;
        }

        void processBulk(IEnumerable<int> episodes, bool doSeparate)
        {

            // For each episode
            foreach (int i in episodes)
            {
                try
                {
                    setLabel("Gathering Episode #" + i);
                    Image episode = downloadEpisode(i);

                    if (doSeparate)
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
