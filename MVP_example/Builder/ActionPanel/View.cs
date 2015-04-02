using System.Windows.Forms;
using MVP_example.Framework.ActionFilterPanel.UserControls;
using MVP_example.Framework.UserControls;

namespace MVP_example.Builder.ActionPanel
{
    public partial class View : UserControl, IView
    {
        public HostPanel HostPanel { get; set; }

        public View()
        {
            InitializeComponent();
        }

        public void SetPanel(HostPanel hostPanel)
        {
            HostPanel = hostPanel;
            HostPanel.Controls.Add(this);
            HostPanel.Initialise();
        }
    }
}
