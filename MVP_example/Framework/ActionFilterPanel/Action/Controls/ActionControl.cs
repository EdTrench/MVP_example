using System;
using System.Windows.Forms;

namespace MVP_example.Framework.ActionFilterPanel.Action.Controls
{
    public abstract class ActionControl : IActionControl
    {
        public Control PanelControl { get; set; }
        public Control AssociatedControl { get; set; }
        public System.Action RefreshAction { get; set; }

        public abstract Panel CreateControlPanel();
        
        public void OnRefresh(System.Action actionDelegate)
        {
            RefreshAction = actionDelegate;
        }
    }
}