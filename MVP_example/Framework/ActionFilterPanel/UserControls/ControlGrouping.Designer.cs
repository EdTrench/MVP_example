namespace MVP_example.Framework.ActionFilterPanel.UserControls
{
    partial class ControlGrouping
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.pbExpandCollapse = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbExpandCollapse)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(203, 23);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Header";
            this.lblHeader.Click += new System.EventHandler(this.lblHeader_Click);
            // 
            // pbExpandCollapse
            // 
            this.pbExpandCollapse.Location = new System.Drawing.Point(209, 3);
            this.pbExpandCollapse.Name = "pbExpandCollapse";
            this.pbExpandCollapse.Size = new System.Drawing.Size(29, 20);
            this.pbExpandCollapse.TabIndex = 1;
            this.pbExpandCollapse.TabStop = false;
            this.pbExpandCollapse.Click += new System.EventHandler(this.pbExpandCollapse_Click);
            // 
            // ControlGrouping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbExpandCollapse);
            this.Controls.Add(this.lblHeader);
            this.Name = "ControlGrouping";
            this.Size = new System.Drawing.Size(241, 27);
            ((System.ComponentModel.ISupportInitialize)(this.pbExpandCollapse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.PictureBox pbExpandCollapse;


    }
}
