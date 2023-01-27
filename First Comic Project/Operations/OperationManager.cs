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
        /*
         * Events
         */
        public struct ProgressUpdateArgs
        {
            public string label;
            public int progressStatus;
            public int progressMaximum;

            public ProgressUpdateArgs(string label, int progressStatus, int progressMaximum)
            {
                this.label = label;
                this.progressStatus = progressStatus;
                this.progressMaximum = progressMaximum;
            }
        };

        public event EventHandler<ProgressUpdateArgs> onProgressUpdate;
        public event EventHandler<EventArgs> onComplete;

        // Form
        private Form1 form;

        public OperationManager(Form1 form)
        {
            this.form = form;
        }

        /// <summary>
        /// Start an operation.
        /// </summary>
        /// <param name="episodes">List of episodes to process.</param>
        /// <param name="separatorSelector">Standard of whitespace. Null if not separating.</param>
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

        /// <summary>
        /// Download episode.
        /// </summary>
        /// <param name="episodeId">The url id of the episode</param>
        /// <returns>Episode image</returns>
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

        /// <summary>
        /// Separate and export the panels of an episode.
        /// </summary>
        /// <param name="episodeId"></param>
        /// <param name="episode"></param>
        /// <param name="separatorSelector"></param>
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

        /// <summary>
        /// Process bulk episodes.
        /// </summary>
        /// <param name="episodes"></param>
        /// <param name="separatorSelector"></param>
        void processBulk(IEnumerable<int> episodes, SeparatorSelection separatorSelector)
        {
            // Create snapshost
            var progressUpdate = onProgressUpdate;
            var complete = onComplete;

            int episodeCount = episodes.Count();

            // For each episode
            foreach (int i in episodes)
            {
                // Graphic update.
                form.BeginInvoke(new MethodInvoker(() => progressUpdate?.Invoke(this, new ProgressUpdateArgs("Gathering Episode #" + i, i, episodeCount))));

                Image episode = downloadEpisode(i);

                // If the selector is null, then you don't separate.
                if (separatorSelector != null)
                {
                    // Graphic update.
                    form.BeginInvoke(new MethodInvoker(() => progressUpdate?.Invoke(this, new ProgressUpdateArgs("Separating the panels for Episode #" + i, i, episodeCount))));

                    separatePanels(i, episode, separatorSelector);
                }

            }

            // Graphic update.
            form.BeginInvoke(new MethodInvoker(() => complete?.Invoke(this, EventArgs.Empty)));

            // Open Folder
            Process.Start(getExportPath());
        }

    }
}
