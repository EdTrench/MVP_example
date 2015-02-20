using System.Collections.Generic;
using MVP_example.Framework.ActionFilterPanel.Action;
using MVP_example.Framework.ActionFilterPanel.UserControls;

namespace MVP_example.Builder.ActionPanel.Framework
{
    public class ActionPanel
    {
        protected IList<ActionControlGrouping> _actionControlGroupings;
        private readonly ActionTableLayoutPanel _actionTableLayoutPanel;

        protected ActionPanel(ActionTableLayoutPanel actionTableLayoutPanel)
        {
            _actionTableLayoutPanel = actionTableLayoutPanel;
            _actionControlGroupings = new List<ActionControlGrouping>();
        }

        public void Refresh()
        {
            _actionTableLayoutPanel.ClearActionPanelComponents();
            foreach (ActionControlGrouping actionControlGrouping in _actionControlGroupings)
            {
                _actionTableLayoutPanel.RegisterActionControlGroup(actionControlGrouping);
            }
            _actionTableLayoutPanel.BuildActionPanelComponents();
        }
    }
}
