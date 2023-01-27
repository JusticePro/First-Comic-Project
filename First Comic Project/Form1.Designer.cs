
namespace First_Comic_Project
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.urlBox = new System.Windows.Forms.TextBox();
            this.checkBoxSeparate = new System.Windows.Forms.CheckBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.buttonStart = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.darkSpinner = new System.Windows.Forms.NumericUpDown();
            this.darkBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelProgress = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.controlPanelGathering = new First_Comic_Project.Controls.ControlPanelGathering();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.darkSpinner)).BeginInit();
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
            // checkBoxSeparate
            // 
            this.checkBoxSeparate.AutoSize = true;
            this.checkBoxSeparate.Location = new System.Drawing.Point(6, 16);
            this.checkBoxSeparate.Name = "checkBoxSeparate";
            this.checkBoxSeparate.Size = new System.Drawing.Size(143, 17);
            this.checkBoxSeparate.TabIndex = 12;
            this.checkBoxSeparate.Text = "Enable Panel Seperation";
            this.checkBoxSeparate.UseVisualStyleBackColor = true;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.darkSpinner);
            this.groupBox2.Controls.Add(this.darkBox);
            this.groupBox2.Controls.Add(this.checkBoxSeparate);
            this.groupBox2.Location = new System.Drawing.Point(12, 204);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(546, 160);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Panel Seperation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Whitespace Ceiling";
            // 
            // darkSpinner
            // 
            this.darkSpinner.Location = new System.Drawing.Point(104, 57);
            this.darkSpinner.Name = "darkSpinner";
            this.darkSpinner.Size = new System.Drawing.Size(436, 20);
            this.darkSpinner.TabIndex = 11;
            // 
            // darkBox
            // 
            this.darkBox.AutoSize = true;
            this.darkBox.Location = new System.Drawing.Point(6, 39);
            this.darkBox.Name = "darkBox";
            this.darkBox.Size = new System.Drawing.Size(79, 17);
            this.darkBox.TabIndex = 10;
            this.darkBox.Text = "Dark Mode";
            this.darkBox.UseVisualStyleBackColor = true;
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
            // colorDialog1
            // 
            this.colorDialog1.Color = System.Drawing.Color.White;
            // 
            // controlPanelGathering
            // 
            this.controlPanelGathering.Location = new System.Drawing.Point(12, 32);
            this.controlPanelGathering.Name = "controlPanelGathering";
            this.controlPanelGathering.Size = new System.Drawing.Size(546, 166);
            this.controlPanelGathering.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 478);
            this.Controls.Add(this.controlPanelGathering);
            this.Controls.Add(this.labelProgress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.urlBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "First Comic Project 1.1.0 (Beta)";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.darkSpinner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.CheckBox checkBoxSeparate;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.NumericUpDown darkSpinner;
        public System.Windows.Forms.CheckBox darkBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelProgress;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private Controls.ControlPanelGathering controlPanelGathering;
    }
}

