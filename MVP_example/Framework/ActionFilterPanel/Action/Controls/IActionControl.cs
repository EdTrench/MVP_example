using System.Windows.Forms;

namespace MVP_example.Framework.ActionFilterPanel.Action.Controls
{
    public interface IActionControl
    {
        Control PanelControl { get; set; }
        Control AssociatedControl { get; set; }
        System.Action RefreshAction { get; set; }
        Panel CreateControlPanel();
        void OnRefresh(System.Action actionDelegate);
    }
}
