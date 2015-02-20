namespace MVP_example.Framework.ActionFilterPanel.Action.Controls.LinkLabel.UserControls
{
    partial class LinkLabelActionControl
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
            this.lnkControl = new System.Windows.Forms.LinkLabel();
            this.pbControl = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbControl)).BeginInit();
            this.SuspendLayout();
            // 
            // lnkControl
            // 
            this.lnkControl.AutoSize = true;
            this.lnkControl.Location = new System.Drawing.Point(27, 1);
            this.lnkControl.Name = "lnkControl";
            this.lnkControl.Size = new System.Drawing.Size(54, 13);
            this.lnkControl.TabIndex = 0;
            this.lnkControl.TabStop = true;
            this.lnkControl.Text = "lnkControl";
            // 
            // pbControl
            // 
            this.pbControl.Location = new System.Drawing.Point(5, 1);
            this.pbControl.Name = "pbControl";
            this.pbControl.Size = new System.Drawing.Size(16, 13);
            this.pbControl.TabIndex = 1;
            this.pbControl.TabStop = false;
            // 
            // LinkLabelActionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbControl);
            this.Controls.Add(this.lnkControl);
            this.Name = "LinkLabelActionControl";
            this.Size = new System.Drawing.Size(224, 16);
            ((System.ComponentModel.ISupportInitialize)(this.pbControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnkControl;
        private System.Windows.Forms.PictureBox pbControl;
    }
}
