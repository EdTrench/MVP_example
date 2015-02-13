using System;
using System.Windows.Forms;
using MVP_example.Properties;

namespace MVP_example.Framework.ActionFilterPanel.UserControls
{
    public partial class ControlGrouping : UserControl
    {
        private Boolean _isExpanded = true;

        public ControlGrouping()
        {
            InitializeComponent();
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
