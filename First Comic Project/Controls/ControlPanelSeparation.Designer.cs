
namespace First_Comic_Project.Controls
{
    partial class ControlPanelSeparation
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
            this.separatingGroupBox = new System.Windows.Forms.GroupBox();
            this.separatorSelectionMode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.autotrimSpinner = new System.Windows.Forms.NumericUpDown();
            this.separatingGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autotrimSpinner)).BeginInit();
            this.SuspendLayout();
            // 
            // separatingGroupBox
            // 
            this.separatingGroupBox.Controls.Add(this.separatorSelectionMode);
            this.separatingGroupBox.Location = new System.Drawing.Point(3, 3);
            this.separatingGroupBox.Name = "separatingGroupBox";
            this.separatingGroupBox.Size = new System.Drawing.Size(546, 163);
            this.separatingGroupBox.TabIndex = 0;
            this.separatingGroupBox.TabStop = false;
            this.separatingGroupBox.Text = "Panel Separation";
            // 
            // separatorSelectionMode
            // 
            this.separatorSelectionMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.separatorSelectionMode.FormattingEnabled = true;
            this.separatorSelectionMode.Items.AddRange(new object[] {
            "Off",
            "Static Color",
            "Brightness"});
            this.separatorSelectionMode.Location = new System.Drawing.Point(6, 19);
            this.separatorSelectionMode.Name = "separatorSelectionMode";
            this.separatorSelectionMode.Size = new System.Drawing.Size(534, 21);
            this.separatorSelectionMode.TabIndex = 13;
            this.separatorSelectionMode.SelectedIndexChanged += new System.EventHandler(this.separatorSelectionMode_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ignore panels shorter than or equal to:";
            // 
            // autotrimSpinner
            // 
            this.autotrimSpinner.Location = new System.Drawing.Point(198, 172);
            this.autotrimSpinner.Name = "autotrimSpinner";
            this.autotrimSpinner.Size = new System.Drawing.Size(120, 20);
            this.autotrimSpinner.TabIndex = 2;
            this.autotrimSpinner.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // ControlPanelSeparation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.autotrimSpinner);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.separatingGroupBox);
            this.Name = "ControlPanelSeparation";
            this.Size = new System.Drawing.Size(561, 208);
            this.Load += new System.EventHandler(this.ControlPanelSeparation_Load);
            this.separatingGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.autotrimSpinner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox separatingGroupBox;
        private System.Windows.Forms.ComboBox separatorSelectionMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown autotrimSpinner;
    }
}
