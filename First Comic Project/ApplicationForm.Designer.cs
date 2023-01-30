
namespace First_Comic_Project
{
    partial class ApplicationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationForm));
            this.urlBox = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.buttonStart = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labelProgress = new System.Windows.Forms.Label();
            this.controlPanelGathering = new First_Comic_Project.Controls.ControlPanelGathering();
            this.controlPanelSeparator = new First_Comic_Project.Controls.ControlPanelSeparation();
            this.SuspendLayout();
            // 
            // urlBox
            // 
            this.urlBox.Location = new System.Drawing.Point(12, 6);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(546, 20);
            this.urlBox.TabIndex = 11;
            this.urlBox.Text = "https://www.webtoons.com/en/sf/space-boy/ep-1/viewer?title_no=400&episode_no=";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 393);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(552, 23);
            this.progressBar.TabIndex = 13;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(12, 422);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(552, 23);
            this.buttonStart.TabIndex = 14;
            this.buttonStart.Text = "Process Bulk Gathering";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(331, 453);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Created by JusticePro for the Space Boy Fandub";
            // 
            // labelProgress
            // 
            this.labelProgress.AutoSize = true;
            this.labelProgress.Location = new System.Drawing.Point(15, 373);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(0, 13);
            this.labelProgress.TabIndex = 17;
            // 
            // controlPanelGathering
            // 
            this.controlPanelGathering.Location = new System.Drawing.Point(12, 32);
            this.controlPanelGathering.Name = "controlPanelGathering";
            this.controlPanelGathering.Size = new System.Drawing.Size(546, 166);
            this.controlPanelGathering.TabIndex = 18;
            // 
            // controlPanelSeparator
            // 
            this.controlPanelSeparator.Location = new System.Drawing.Point(12, 204);
            this.controlPanelSeparator.Name = "controlPanelSeparator";
            this.controlPanelSeparator.Size = new System.Drawing.Size(546, 166);
            this.controlPanelSeparator.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 478);
            this.Controls.Add(this.controlPanelSeparator);
            this.Controls.Add(this.controlPanelGathering);
            this.Controls.Add(this.labelProgress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.urlBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "First Comic Project 1.1.0 (Beta)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelProgress;
        private Controls.ControlPanelGathering controlPanelGathering;
        private Controls.ControlPanelSeparation controlPanelSeparator;
    }
}

