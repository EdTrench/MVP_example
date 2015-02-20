using System.Collections.Generic;
using System.Windows.Forms;

namespace MVP_example.Framework.ActionFilterPanel.UserControls
{
    public partial class ActionTableLayoutPanel : UserControl
    {

        public delegate void ActionRefreshHandler();

        public event ActionRefreshHandler CallRefresh;

        public int ColumnCount
        {
            get { return tlpActionFilterPanel.ColumnCount; }
            set { tlpActionFilterPanel.ColumnCount = value; }
        }

        private readonly IList<ActionFilterPanel.ControlGrouping> _controlGroupings;

        public ActionTableLayoutPanel()
        {
            InitializeComponent();
            _controlGroupings = new List<ActionFilterPanel.ControlGrouping>();
            ClearActionPanelComponents();
        }

        public void ClearActionPanelComponents()
        {
            _controlGroupings.Clear();
            tlpActionFilterPanel.Controls.Clear();
            tlpActionFilterPanel.RowStyles.Clear();
        }

        public void RegisterActionControlGroup(ActionFilterPanel.ControlGrouping controlGrouping)
        {
            controlGrouping.SetRefreshDelegate(OnRefresh);
        }

        public void BuildActionPanelComponents()
        {
            foreach (ActionFilterPanel.ControlGrouping controlGrouping in _controlGroupings)
            {
                controlGrouping.BuildActionPanel();
            }
        }
        
        public bool HasControls()
        {
            int countOfControls = 0;
            foreach (ActionFilterPanel.ControlGrouping controlGrouping in _controlGroupings)
            {
                countOfControls += controlGrouping.CountOfControls();
            }
            return (countOfControls > 0);
        }

        public void OnRefresh()
        {
            CallRefresh();
        }

    }
}
