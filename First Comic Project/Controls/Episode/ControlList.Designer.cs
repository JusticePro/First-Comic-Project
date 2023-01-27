
namespace First_Comic_Project.Controls.Episode
{
    partial class ControlList
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
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Comma Separated List (Ex: 41,22,31):";
            // 
            // richTextBox1
            // 
            this.richTextBox.Location = new System.Drawing.Point(3, 21);
            this.richTextBox.Name = "richTextBox1";
            this.richTextBox.Size = new System.Drawing.Size(534, 93);
            this.richTextBox.TabIndex = 20;
            this.richTextBox.Text = "";
            // 
            // ControlList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.label2);
            this.Name = "ControlList";
            this.Size = new System.Drawing.Size(540, 117);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox;
    }
}
