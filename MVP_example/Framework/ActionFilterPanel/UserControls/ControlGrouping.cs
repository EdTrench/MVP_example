using System;
using System.Windows.Forms;
using MVP_example.Properties;

namespace MVP_example.Framework.ActionFilterPanel.UserControls
{
    public partial class ControlGrouping : UserControl
    {
        public event EventHandler<bool> RaiseExpandCollapse;

        private Boolean _isExpanded = true;

        public ControlGrouping()
        {
            InitializeComponent();
        }

        public string HeaderText
        {
            get { return lblHeader.Text; } 
            set { lblHeader.Text = value; }
        }

        public void SetHeaderLabel(string text)
        {
            lblHeader.Text = text;
        }

        public void SetHeaderVisibility(bool isVisible)
        {
            lblHeader.Visible = isVisible;
        }

        public void SetExpandCollapseVisibility(bool isVisible)
        {
            pbExpandCollapse.Visible = isVisible;
        }

        private void CollapsePanel()
        {
            if (_isExpanded)
            {
                _isExpanded = false;
                pbExpandCollapse.Image = Resources.ExpandSmall;
            }
            else
            {
                _isExpanded = true;
                pbExpandCollapse.Image = Resources.CollapseSmall;
            }
            RaiseExpandCollapse(this, _isExpanded);
        }

        private void lblHeader_Click(object sender, EventArgs e)
        {
            CollapsePanel();
        }

        private void pbExpandCollapse_Click(object sender, EventArgs e)
        {
            CollapsePanel();
        }
    }
}
