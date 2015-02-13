namespace MVP_example.Builder.ActionPanel
{
    partial class View
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
            this.ActionTableLayoutPanel = new MVP_example.Framework.ActionFilterPanel.UserControls.ActionTableLayoutPanel();
            this.SuspendLayout();
            // 
            // ActionTableLayoutPanel
            // 
            this.ActionTableLayoutPanel.Location = new System.Drawing.Point(4, 3);
            this.ActionTableLayoutPanel.Name = "ActionTableLayoutPanel";
            this.ActionTableLayoutPanel.Size = new System.Drawing.Size(170, 339);
            this.ActionTableLayoutPanel.TabIndex = 0;
            // 
            // View
            // 
            this.Controls.Add(this.ActionTableLayoutPanel);
            this.Name = "View";
            this.Size = new System.Drawing.Size(180, 351);
            this.ResumeLayout(false);

        }

        #endregion

        private MVP_example.Framework.ActionFilterPanel.UserControls.ActionTableLayoutPanel ActionTableLayoutPanel;

        
    }
}
