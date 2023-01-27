
namespace First_Comic_Project.Controls.Separator
{
    partial class ControlBrightness
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
            this.label1 = new System.Windows.Forms.Label();
            this.spinnerCeiling = new System.Windows.Forms.NumericUpDown();
            this.spinnerFloor = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerCeiling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerFloor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(525, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Panels will be separated based on the brightness of the color. If the color\'s red" +
    ", green, and blue are between the two numbers, then it is considered whitespace." +
    "";
            // 
            // spinnerCeiling
            // 
            this.spinnerCeiling.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinnerCeiling.Location = new System.Drawing.Point(111, 40);
            this.spinnerCeiling.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.spinnerCeiling.Name = "spinnerCeiling";
            this.spinnerCeiling.Size = new System.Drawing.Size(120, 20);
            this.spinnerCeiling.TabIndex = 2;
            // 
            // spinnerFloor
            // 
            this.spinnerFloor.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinnerFloor.Location = new System.Drawing.Point(111, 66);
            this.spinnerFloor.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.spinnerFloor.Name = "spinnerFloor";
            this.spinnerFloor.Size = new System.Drawing.Size(120, 20);
            this.spinnerFloor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Brightness Ceiling:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Brightness Floor:";
            // 
            // ControlBrightness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.spinnerFloor);
            this.Controls.Add(this.spinnerCeiling);
            this.Controls.Add(this.label1);
            this.Name = "ControlBrightness";
            this.Size = new System.Drawing.Size(540, 117);
            ((System.ComponentModel.ISupportInitialize)(this.spinnerCeiling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerFloor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown spinnerCeiling;
        private System.Windows.Forms.NumericUpDown spinnerFloor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
