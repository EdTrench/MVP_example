using System.Windows.Forms;
using MVP_example.Framework.UserControls;

namespace MVP_example.Framework.Forms.Base_Forms
{
    public partial class HostFormSeperateActionPanel : Form
    {
        public HostFormSeperateActionPanel(string formText)
        {
            InitializeComponent();
            Text = formText;
        }

        public StatusStrip StatusStrip
        {
            get { return HostFormStatusStrip ; }
            set { HostFormStatusStrip = value; }
        }

        public HostPanel MainPanel
        {
            get { return HostMainPanel; }
        }

        public HostPanel ActionPanel
        {
            get { return HostActionPanel; }
        }
    }
}
