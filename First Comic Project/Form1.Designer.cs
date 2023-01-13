
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.spinnerEpisodeEnd = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.spinnerEpisodeStart = new System.Windows.Forms.NumericUpDown();
            this.urlBox = new System.Windows.Forms.TextBox();
            this.checkBoxSeparate = new System.Windows.Forms.CheckBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.buttonProcessBulk = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.darkSpinner = new System.Windows.Forms.NumericUpDown();
            this.darkBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelProgress = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerEpisodeEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerEpisodeStart)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.darkSpinner)).BeginInit();
            this.SuspendLayout();
            // 
            // colorDialog1
            // 
            this.colorDialog1.Color = System.Drawing.Color.White;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.spinnerEpisodeEnd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.spinnerEpisodeStart);
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(546, 163);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Panel Gathering";
            // 
            // spinnerEpisodeEnd
            // 
            this.spinnerEpisodeEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spinnerEpisodeEnd.Location = new System.Drawing.Point(95, 42);
            this.spinnerEpisodeEnd.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.spinnerEpisodeEnd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinnerEpisodeEnd.Name = "spinnerEpisodeEnd";
            this.spinnerEpisodeEnd.Size = new System.Drawing.Size(445, 20);
            this.spinnerEpisodeEnd.TabIndex = 9;
            this.spinnerEpisodeEnd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "End Episode:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Starting Episode:";
            // 
            // spinnerEpisodeStart
            // 
            this.spinnerEpisodeStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spinnerEpisodeStart.Location = new System.Drawing.Point(95, 16);
            this.spinnerEpisodeStart.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.spinnerEpisodeStart.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinnerEpisodeStart.Name = "spinnerEpisodeStart";
            this.spinnerEpisodeStart.Size = new System.Drawing.Size(445, 20);
            this.spinnerEpisodeStart.TabIndex = 6;
            this.spinnerEpisodeStart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            // buttonProcessBulk
            // 
            this.buttonProcessBulk.Location = new System.Drawing.Point(12, 422);
            this.buttonProcessBulk.Name = "buttonProcessBulk";
            this.buttonProcessBulk.Size = new System.Drawing.Size(552, 23);
            this.buttonProcessBulk.TabIndex = 14;
            this.buttonProcessBulk.Text = "Process Bulk Gathering";
            this.buttonProcessBulk.UseVisualStyleBackColor = true;
            this.buttonProcessBulk.Click += new System.EventHandler(this.button4_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 478);
            this.Controls.Add(this.labelProgress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonProcessBulk);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.urlBox);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "First Comic Project 1.1.0 (Beta)";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerEpisodeEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerEpisodeStart)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.darkSpinner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown spinnerEpisodeEnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown spinnerEpisodeStart;
        public System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.CheckBox checkBoxSeparate;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button buttonProcessBulk;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.NumericUpDown darkSpinner;
        public System.Windows.Forms.CheckBox darkBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelProgress;
    }
}

