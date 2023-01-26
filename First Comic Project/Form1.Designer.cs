
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.episodeIdSelector = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.darkSpinner = new System.Windows.Forms.NumericUpDown();
            this.darkBox = new System.Windows.Forms.CheckBox();
            this.colorSelector = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.labelProgress = new System.Windows.Forms.Label();
            this.buttonProcessBulk = new System.Windows.Forms.Button();
            this.checkBoxSeparate = new System.Windows.Forms.CheckBox();
            this.spinnerEpisodeEnd = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.spinnerEpisodeStart = new System.Windows.Forms.NumericUpDown();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.urlBox = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.episodeIdSelector)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.darkSpinner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorSelector)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerEpisodeEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerEpisodeStart)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(331, 460);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.episodeIdSelector);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(323, 434);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Panel Gathering";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(8, 374);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(307, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = "Open Episode";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(8, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(307, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Download Episode";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // episodeIdSelector
            // 
            this.episodeIdSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.episodeIdSelector.Location = new System.Drawing.Point(68, 6);
            this.episodeIdSelector.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.episodeIdSelector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.episodeIdSelector.Name = "episodeIdSelector";
            this.episodeIdSelector.Size = new System.Drawing.Size(247, 20);
            this.episodeIdSelector.TabIndex = 1;
            this.episodeIdSelector.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Episode ID:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.darkSpinner);
            this.tabPage2.Controls.Add(this.darkBox);
            this.tabPage2.Controls.Add(this.colorSelector);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(323, 434);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Panel Separating";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Whitespace Ceiling";
            // 
            // darkSpinner
            // 
            this.darkSpinner.Location = new System.Drawing.Point(106, 114);
            this.darkSpinner.Name = "darkSpinner";
            this.darkSpinner.Size = new System.Drawing.Size(209, 20);
            this.darkSpinner.TabIndex = 5;
            // 
            // darkBox
            // 
            this.darkBox.AutoSize = true;
            this.darkBox.Location = new System.Drawing.Point(8, 91);
            this.darkBox.Name = "darkBox";
            this.darkBox.Size = new System.Drawing.Size(49, 17);
            this.darkBox.TabIndex = 4;
            this.darkBox.Text = "Dark";
            this.darkBox.UseVisualStyleBackColor = true;
            // 
            // colorSelector
            // 
            this.colorSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.colorSelector.BackColor = System.Drawing.Color.White;
            this.colorSelector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorSelector.Location = new System.Drawing.Point(8, 61);
            this.colorSelector.Name = "colorSelector";
            this.colorSelector.Size = new System.Drawing.Size(307, 24);
            this.colorSelector.TabIndex = 3;
            this.colorSelector.TabStop = false;
            this.colorSelector.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(8, 403);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(307, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Separate Panels";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(8, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(307, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Select File";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(8, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(307, 20);
            this.textBox1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.progressBar);
            this.tabPage3.Controls.Add(this.labelProgress);
            this.tabPage3.Controls.Add(this.buttonProcessBulk);
            this.tabPage3.Controls.Add(this.checkBoxSeparate);
            this.tabPage3.Controls.Add(this.spinnerEpisodeEnd);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.spinnerEpisodeStart);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(323, 434);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Bulk Gathering";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(8, 374);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(307, 23);
            this.progressBar.TabIndex = 8;
            // 
            // labelProgress
            // 
            this.labelProgress.AutoSize = true;
            this.labelProgress.Location = new System.Drawing.Point(8, 358);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(0, 13);
            this.labelProgress.TabIndex = 7;
            // 
            // buttonProcessBulk
            // 
            this.buttonProcessBulk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProcessBulk.Location = new System.Drawing.Point(8, 403);
            this.buttonProcessBulk.Name = "buttonProcessBulk";
            this.buttonProcessBulk.Size = new System.Drawing.Size(307, 23);
            this.buttonProcessBulk.TabIndex = 6;
            this.buttonProcessBulk.Text = "Process Bulk Gathering";
            this.buttonProcessBulk.UseVisualStyleBackColor = true;
            this.buttonProcessBulk.Click += new System.EventHandler(this.button4_Click);
            // 
            // checkBoxSeparate
            // 
            this.checkBoxSeparate.AutoSize = true;
            this.checkBoxSeparate.Location = new System.Drawing.Point(11, 58);
            this.checkBoxSeparate.Name = "checkBoxSeparate";
            this.checkBoxSeparate.Size = new System.Drawing.Size(104, 17);
            this.checkBoxSeparate.TabIndex = 5;
            this.checkBoxSeparate.Text = "Separate Panels";
            this.checkBoxSeparate.UseVisualStyleBackColor = true;
            // 
            // spinnerEpisodeEnd
            // 
            this.spinnerEpisodeEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spinnerEpisodeEnd.Location = new System.Drawing.Point(100, 32);
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
            this.spinnerEpisodeEnd.Size = new System.Drawing.Size(215, 20);
            this.spinnerEpisodeEnd.TabIndex = 3;
            this.spinnerEpisodeEnd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "End Episode:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Starting Episode:";
            // 
            // spinnerEpisodeStart
            // 
            this.spinnerEpisodeStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spinnerEpisodeStart.Location = new System.Drawing.Point(100, 6);
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
            this.spinnerEpisodeStart.Size = new System.Drawing.Size(215, 20);
            this.spinnerEpisodeStart.TabIndex = 0;
            this.spinnerEpisodeStart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.urlBox);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(323, 434);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Select Comic";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // urlBox
            // 
            this.urlBox.Location = new System.Drawing.Point(8, 6);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(307, 20);
            this.urlBox.TabIndex = 0;
            this.urlBox.Text = "https://www.webtoons.com/en/sf/space-boy/ep-1/viewer?title_no=400&episode_no=";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(323, 434);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Credits";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Created by JusticePro for the Spaceboy Fandub";
            // 
            // colorDialog1
            // 
            this.colorDialog1.Color = System.Drawing.Color.White;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 460);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "First Comic Project 1.0.4 (Unlocked)";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.episodeIdSelector)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.darkSpinner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorSelector)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerEpisodeEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerEpisodeStart)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.NumericUpDown episodeIdSelector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown spinnerEpisodeStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown spinnerEpisodeEnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxSeparate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonProcessBulk;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox colorSelector;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label labelProgress;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TabPage tabPage5;
        public System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.NumericUpDown darkSpinner;
        public System.Windows.Forms.CheckBox darkBox;
    }
}

