using System;
using System.Windows.Forms;
using MVP_example.Framework.ActionFilterPanel.Action;
using MVP_example.Framework.ActionFilterPanel.Action.Controls.LinkLabel.UserControls;
using MVP_example.Framework.ActionFilterPanel.UserControls;

namespace MVP_example.Builder.ActionPanel.Garden
{
    public class Garden : Framework.ActionPanel
    {
        private ActionControlGrouping _gardenGroup;

        public event EventHandler Save;

        public Garden(ActionTableLayoutPanel actionTableLayoutPanel)
            : base(actionTableLayoutPanel)
        {

        }

        public void BuildGroupings()
        {
            _gardenGroup = new ActionControlGrouping("Garden", new TableLayoutPanel());
            _gardenGroup.RegisterActionControl(new LinkLabelActionControl("Save", () => Save(this, EventArgs.Empty)));
        }

        public void AddGroupings()
        {
            _actionControlGroupings.Add(_gardenGroup);
        }
    }
}
