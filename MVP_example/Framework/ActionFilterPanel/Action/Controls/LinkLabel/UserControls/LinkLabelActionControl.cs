using System;
using System.Windows.Forms;

namespace MVP_example.Framework.ActionFilterPanel.Action.Controls.LinkLabel.UserControls
{
    public partial class LinkLabelActionControl : UserControl, IActionControl
    {
        public Control PanelControl { get; set; }
        public Control AssociatedControl { get; set; }
        public System.Action RefreshAction { get; set; }
        
        private readonly System.Action _action;

        public LinkLabelActionControl(string text,
            System.Action action)
        {
            InitializeComponent();
            lnkControl.Text = text;
            _action = action;
        }
        
        public Panel CreateControlPanel()
        {
            var panel = new Panel() {Dock = DockStyle.Fill, Height = 18};
            panel.Controls.Add(this);
            PanelControl = panel;
            lnkControl.Click += Execute;
            AssociatedControl = lnkControl;
            return panel;
        }

        public void Execute(object sender, EventArgs eventArgs)
        {
            if (_action != null) { _action.Invoke(); }
            if (RefreshAction != null) { RefreshAction.Invoke(); }
        }

        public void OnRefresh(System.Action actionDelegate)
        {
            RefreshAction = actionDelegate;
        }
    }
}
