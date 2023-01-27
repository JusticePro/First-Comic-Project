using First_Comic_Project.Controls.Episode;
using First_Comic_Project.Operations;
using First_Comic_Project.Operations.Selectors;
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
        private OperationManager operationManager;

        public Form1()
        {
            InitializeComponent();
            instance = this;

            // Setup Operation Manager
            this.operationManager = new OperationManager(this);

            operationManager.onProgressUpdate += onProgressUpdate;
            operationManager.onComplete += onComplete;
        }

        /// <summary>
        /// Event triggered by OperationManager when progress is made.
        /// </summary>
        private void onProgressUpdate(object sender, OperationManager.ProgressUpdateArgs eventArgs)
        {
            labelProgress.Text = eventArgs.label;
            progressBar.Maximum = eventArgs.progressMaximum;
            progressBar.Value = eventArgs.progressStatus;
        }

        /// <summary>
        /// Event triggered by OperationManager when the operation is complete.
        /// </summary>
        private void onComplete(object sender, EventArgs eventArgs)
        {
            // Reset Progress Indicators
            progressBar.Value = 0;
            labelProgress.Text = "";

            buttonStart.Enabled = true;
            Cursor = Cursors.Default;

            SystemSounds.Beep.Play();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            startOperation();
        }

        /// <summary>
        /// Start any type of operation.
        /// </summary>
        void startOperation()
        {
            IEnumerable<int> episodes = controlPanelGathering.getEpisodes();

            // Episodes may be null if there was an issue in its selection.
            if (episodes != null)
            {
                // Make graphical changes.
                Cursor = Cursors.WaitCursor;
                buttonStart.Enabled = false;
                progressBar.Maximum = episodes.Count();

                // Start operation.
                operationManager.startOperation(episodes, controlPanelSeparator.getSelector());
            }

        }

    }
}
