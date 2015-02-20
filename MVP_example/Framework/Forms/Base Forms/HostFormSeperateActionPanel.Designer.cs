namespace MVP_example.Framework.Forms.Base_Forms
{
    partial class HostFormSeperateActionPanel
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
            this.HostMainPanel = new MVP_example.Framework.UserControls.HostPanel();
            this.HostActionPanel = new MVP_example.Framework.UserControls.HostPanel();
            this.HostFormStatusStrip = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.HostFormStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // HostMainPanel
            // 
            this.HostMainPanel.Location = new System.Drawing.Point(3, 2);
            this.HostMainPanel.Name = "HostMainPanel";
            this.HostMainPanel.Size = new System.Drawing.Size(790, 357);
            this.HostMainPanel.TabIndex = 0;
            // 
            // HostActionPanel
            // 
            this.HostActionPanel.Location = new System.Drawing.Point(800, 2);
            this.HostActionPanel.Name = "HostActionPanel";
            this.HostActionPanel.Size = new System.Drawing.Size(177, 357);
            this.HostActionPanel.TabIndex = 1;
            // 
            // HostFormStatusStrip
            // 
            this.HostFormStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel});
            this.HostFormStatusStrip.Location = new System.Drawing.Point(0, 360);
            this.HostFormStatusStrip.Name = "HostFormStatusStrip";
            this.HostFormStatusStrip.Size = new System.Drawing.Size(980, 22);
            this.HostFormStatusStrip.TabIndex = 2;
            this.HostFormStatusStrip.Text = "HostFormStatusStrip";
            // 
            // ToolStripStatusLabel
            // 
            this.ToolStripStatusLabel.Name = "ToolStripStatusLabel";
            this.ToolStripStatusLabel.Size = new System.Drawing.Size(115, 17);
            this.ToolStripStatusLabel.Text = "ToolStripStatusLabel";
            // 
            // HostFormSeperateActionPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 382);
            this.Controls.Add(this.HostFormStatusStrip);
            this.Controls.Add(this.HostActionPanel);
            this.Controls.Add(this.HostMainPanel);
            this.Name = "HostFormSeperateActionPanel";
            this.Text = "HostFormSeperateActionPanel";
            this.HostFormStatusStrip.ResumeLayout(false);
            this.HostFormStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.HostPanel HostMainPanel;
        private UserControls.HostPanel HostActionPanel;
        private System.Windows.Forms.StatusStrip HostFormStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel;
    }
}