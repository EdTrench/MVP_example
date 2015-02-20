using System;
using System.Windows.Forms;

namespace MVP_example.Framework.ActionFilterPanel
{
    public abstract class ControlGrouping
    {

        protected UserControls.ControlGrouping _controlGrouping;
        protected string _headerText;
        protected Control _endSeperatorControl;
        protected TableLayoutPanel _tableLayoutPanel;

        protected abstract void AddSubControls();
        protected abstract void SetExpand(Boolean isExpanded);
        
        public abstract int CountOfControls();

        protected System.Action _onRefresh;

        public ControlGrouping(string headerText,
            TableLayoutPanel tableLayoutPanel)
        {
            _headerText = headerText;
            _tableLayoutPanel = tableLayoutPanel;
            _controlGrouping = new UserControls.ControlGrouping();
            _endSeperatorControl = new Label()
            {
                Anchor = AnchorStyles.Left, AutoSize = false, Height = 2, BorderStyle = BorderStyle.Fixed3D, Margin = new Padding(3, 0, 5, 4)
            };
        }

        public void BuildActionPanel()
        {
            AddHeaderLabel();
            AddSubControls();
            AddEndSeperator();
            AutoSize();
        }

        public void SetRefreshDelegate(System.Action action)
        {
            _onRefresh = action;
        }

        private void AddHeaderLabel()
        {
            _controlGrouping.HeaderText = _headerText;
            _tableLayoutPanel.Controls.Add(_controlGrouping, 1, _tableLayoutPanel.RowCount - 1);
        }

        private void AddEndSeperator()
        {
            _tableLayoutPanel.RowCount += 1;
            _tableLayoutPanel.Controls.Add(_endSeperatorControl, 1, _tableLayoutPanel.RowCount - 1);
            _tableLayoutPanel.SetColumnSpan(_endSeperatorControl, 2);
        }

        private void AutoSize()
        {
            foreach (RowStyle rowStyle in _tableLayoutPanel.RowStyles)
            {
                rowStyle.SizeType = SizeType.AutoSize;
            }
            _tableLayoutPanel.RowCount += 1;
        }
    }
}
