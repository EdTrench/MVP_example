namespace MVP_example.Framework.ActionFilterPanel.UserControls
{
    partial class ActionTableLayoutPanel
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
            this.tlpActionFilterPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // tlpActionFilterPanel
            // 
            this.tlpActionFilterPanel.ColumnCount = 1;
            this.tlpActionFilterPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpActionFilterPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpActionFilterPanel.Location = new System.Drawing.Point(0, 0);
            this.tlpActionFilterPanel.Name = "tlpActionFilterPanel";
            this.tlpActionFilterPanel.RowCount = 1;
            this.tlpActionFilterPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpActionFilterPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpActionFilterPanel.Size = new System.Drawing.Size(150, 150);
            this.tlpActionFilterPanel.TabIndex = 0;
            // 
            // ActionTableLayoutPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpActionFilterPanel);
            this.Name = "ActionTableLayoutPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpActionFilterPanel;
    }
}
