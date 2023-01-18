
namespace First_Comic_Project.Controls.Episode
{
    partial class ControlRange
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.spinnerEpisodeEnd = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.spinnerEpisodeStart = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerEpisodeEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerEpisodeStart)).BeginInit();
            this.SuspendLayout();
            // 
            // spinnerEpisodeEnd
            // 
            this.spinnerEpisodeEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spinnerEpisodeEnd.Location = new System.Drawing.Point(95, 29);
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
            this.spinnerEpisodeEnd.Size = new System.Drawing.Size(442, 20);
            this.spinnerEpisodeEnd.TabIndex = 17;
            this.spinnerEpisodeEnd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "End Episode:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Starting Episode:";
            // 
            // spinnerEpisodeStart
            // 
            this.spinnerEpisodeStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spinnerEpisodeStart.Location = new System.Drawing.Point(95, 3);
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
            this.spinnerEpisodeStart.Size = new System.Drawing.Size(442, 20);
            this.spinnerEpisodeStart.TabIndex = 14;
            this.spinnerEpisodeStart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ControlRange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.spinnerEpisodeEnd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.spinnerEpisodeStart);
            this.Name = "ControlRange";
            this.Size = new System.Drawing.Size(540, 117);
            ((System.ComponentModel.ISupportInitialize)(this.spinnerEpisodeEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerEpisodeStart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown spinnerEpisodeEnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown spinnerEpisodeStart;
    }
}
