using First_Comic_Project.Operations.Selectors;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        public void startOperation(IEnumerable<int> episodes, SeparatorSelection separatorSelector)
        {
            Thread thread = new Thread(new ThreadStart(() => processBulk(episodes, separatorSelector)));
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
            try
            {
                Image episode = Gatherer.getComic(episodeId);

                if (episode == null)
                {
                    return null;
                }

                episode.Save(Path.Combine(getExportPath(), "Episode #" + episodeId + ".png"));
                return episode;
            }catch (Exception e)
            {
                return null;
            }
            return null;
        }

        void separatePanels(int episodeId, Image episode, SeparatorSelection separatorSelector)
        {
            try
            {
                string episodeDirectory = Path.Combine(getExportPath(), "Episode #" + episodeId);

                if (!Directory.Exists(episodeDirectory))
                {
                    Directory.CreateDirectory(episodeDirectory);
                }

                List<Image> images = Separator.separatePanels(episode, separatorSelector);

                int x = 0;
                foreach (Image panel in images)
                {
                    panel.Save(Path.Combine(episodeDirectory, "Panel #" + x + ".png"));
                    panel.Dispose();
                    x++;
                }
                episode.Dispose();
            }catch (Exception e)
            {
                Debug.WriteLine("Failed to separate episode " + episodeId + ": " + e.StackTrace);
            }
        }

        void processBulk(IEnumerable<int> episodes, SeparatorSelection separatorSelector)
        {

            // For each episode
            foreach (int i in episodes)
            {
                setLabel("Gathering Episode #" + i);
                Image episode = downloadEpisode(i);

                // If the selector is null, then you don't separate.
                if (separatorSelector != null)
                {
                    setLabel("Separating the panels for Episode #" + i);

                    separatePanels(i, episode, separatorSelector);
                }

                BeginInvoke((MethodInvoker)delegate ()
                {
                    progressBar.Value++;
                });
            }

            BeginInvoke((MethodInvoker)delegate ()
            {
                progressBar.Value = 0;

                buttonStart.Enabled = true;
                Cursor = Cursors.Default;
            });
            setLabel("");

            SystemSounds.Beep.Play();

            // Open Folder
            Process.Start(getExportPath());
        }
    }
}
