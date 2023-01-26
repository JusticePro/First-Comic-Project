
namespace First_Comic_Project.Controls.Episode
{
    partial class ControlSingle
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
            this.label2 = new System.Windows.Forms.Label();
            this.spinnerEpisode = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerEpisode)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Select Episode:";
            // 
            // spinnerEpisode
            // 
            this.spinnerEpisode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spinnerEpisode.Location = new System.Drawing.Point(95, 3);
            this.spinnerEpisode.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.spinnerEpisode.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinnerEpisode.Name = "spinnerEpisode";
            this.spinnerEpisode.Size = new System.Drawing.Size(442, 20);
            this.spinnerEpisode.TabIndex = 16;
            this.spinnerEpisode.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ControlSingle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.spinnerEpisode);
            this.Name = "ControlSingle";
            this.Size = new System.Drawing.Size(540, 117);
            ((System.ComponentModel.ISupportInitialize)(this.spinnerEpisode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown spinnerEpisode;
    }
}
