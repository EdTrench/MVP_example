using System;
using MVP_example.Framework.Forms.Base_Forms;

namespace MVP_example.Presenter.Garden
{
    class Garden : IGarden
    {

        protected readonly HostFormSeperateActionPanel _hostForm;
        protected readonly NHibernate.ISession _sx;

        private Builder.ActionPanel.View _actionPanelView;
        private Framework.IViewEventListener _viewEventListener;
        private Framework.IViewActionPanelEventListener _viewActionPanelEventListener;



        public View.Garden.IGarden GardenView { get; set; }
        public Model.Garden.Garden GardenModel { get; private set; }
        
        public void Show()
        {
            throw new NotImplementedException();
        }

        public void BuildActionPanel()
        {
            throw new NotImplementedException();
        }

        public void RefreshAwardLists()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
