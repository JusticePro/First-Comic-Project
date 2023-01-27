
namespace First_Comic_Project.Controls
{
    partial class ControlPanelGathering
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
            this.gatheringGroupBox = new System.Windows.Forms.GroupBox();
            this.episodeSelectionMode = new System.Windows.Forms.ComboBox();
            this.gatheringGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // gatheringGroupBox
            // 
            this.gatheringGroupBox.Controls.Add(this.episodeSelectionMode);
            this.gatheringGroupBox.Location = new System.Drawing.Point(3, 3);
            this.gatheringGroupBox.Name = "gatheringGroupBox";
            this.gatheringGroupBox.Size = new System.Drawing.Size(546, 163);
            this.gatheringGroupBox.TabIndex = 0;
            this.gatheringGroupBox.TabStop = false;
            this.gatheringGroupBox.Text = "Panel Gathering";
            // 
            // episodeSelectionMode
            // 
            this.episodeSelectionMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.episodeSelectionMode.FormattingEnabled = true;
            this.episodeSelectionMode.Items.AddRange(new object[] {
            "Single",
            "Range",
            "List"});
            this.episodeSelectionMode.Location = new System.Drawing.Point(6, 19);
            this.episodeSelectionMode.Name = "episodeSelectionMode";
            this.episodeSelectionMode.Size = new System.Drawing.Size(534, 21);
            this.episodeSelectionMode.TabIndex = 12;
            this.episodeSelectionMode.SelectedIndexChanged += new System.EventHandler(this.episodeSelectionMode_SelectedIndexChanged);
            // 
            // ControlPanelGathering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gatheringGroupBox);
            this.Name = "ControlPanelGathering";
            this.Size = new System.Drawing.Size(561, 177);
            this.Load += new System.EventHandler(this.ControlPanelGathering_Load);
            this.gatheringGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gatheringGroupBox;
        private System.Windows.Forms.ComboBox episodeSelectionMode;
    }
}
