using System.Collections.Generic;
using System.Windows.Forms;
using MVP_example.Framework.ActionFilterPanel.Action.Controls;

namespace MVP_example.Framework.ActionFilterPanel.Action
{
    public class ActionControlGrouping : ControlGrouping
    {
        private IList<IActionControl> _actionControls;

        public ActionControlGrouping(string headerText,
            TableLayoutPanel tableLayoutPanel) : base(headerText, tableLayoutPanel)
        {
            ClearControls();
        }

        public void RegisterActionControl(IActionControl actionControl)
        {
            actionControl.OnRefresh(_onRefresh);
            _actionControls.Add(actionControl);
        }

        public void SetVisible(bool isVisible)
        {
            foreach (IActionControl actionControl in _actionControls)
            {
                actionControl.AssociatedControl.Visible = isVisible;
            }
            _controlGrouping.SetHeaderVisibility(isVisible);
            _endSeperatorControl.Visible = isVisible;
            _controlGrouping.SetExpandCollapseVisibility(isVisible);
        }

        public void SetEnabled(bool isEnabled)
        {
            foreach (IActionControl actionControl in _actionControls)
            {
                actionControl.AssociatedControl.Enabled = isEnabled;
            }
            _controlGrouping.Enabled = isEnabled;
            _endSeperatorControl.Enabled = isEnabled;
        }

        public void ClearControls()
        {
            _actionControls =  new List<IActionControl>();
        }

        public override int CountOfControls()
        {
            return _actionControls.Count;
        }

        protected override void AddSubControls()
        {
            foreach (IActionControl actionControl in _actionControls)
            {
                _tableLayoutPanel.RowCount += 1;
                _tableLayoutPanel.Controls.Add(actionControl.CreateControlPanel(), 1, _tableLayoutPanel.RowCount - 1);
                _tableLayoutPanel.RowCount += 1;
            }
        }

        protected override void SetExpand(bool isExpanded)
        {
            foreach (IActionControl actionControl in _actionControls)
            {
                actionControl.AssociatedControl.Visible = isExpanded;
                actionControl.PanelControl.Visible = isExpanded;
            }
        }
    }
}