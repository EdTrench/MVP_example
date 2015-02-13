using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVP_example.Framework.DirtyChecker;
using MVP_example.Framework.UserControls;

namespace MVP_example.View.Garden
{
    public partial class Garden : UserControl, IGarden
    {
        public HostPanel HostPanel { get; set; }
        public DirtyControlCheckerWithStatusStrip DirtyControlCheckerWithStatusStrip { get; set; }

        string IGarden.Name { get { return txtName.Text; } set { txtName.Text = value; } }
        string IGarden.Description { get { return txtDescription.Text; } set { txtDescription.Text = value; } }

        public event EventHandler InformUserOfDirtyView;
        public event EventHandler<FormClosingEventArgs> InformUserOfDirtyViewFormClosing;
        public event EventHandler SaveCompletedEventHandler;

        public Garden(StatusStrip statusStrip)
        {
            DirtyControlCheckerWithStatusStrip = new DirtyControlCheckerWithStatusStrip(statusStrip);
            InitializeComponent();
            DirtyControlCheckerWithStatusStrip.AddDirtyEvent(this);
        }
        
        public void SetPanel(HostPanel hostPanel)
        {
            HostPanel = hostPanel;
            HostPanel.Controls.Add(this);
            hostPanel.Initialise();
        }

       
    }
}
