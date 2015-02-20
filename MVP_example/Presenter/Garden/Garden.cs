using System;
using FluentNHibernate.Mapping;
using MVP_example.Framework.Forms.Base_Forms;
using MVP_example.Presenter.Framework;

namespace MVP_example.Presenter.Garden
{
    class Garden : IGarden
    {

        protected readonly HostFormSeperateActionPanel _HostFormSeperateActionPanel;
        protected readonly NHibernate.ISession _sx;

        private Builder.ActionPanel.View _actionPanelView;
        private Framework.IViewEventListener _viewEventListener;
        private Framework.IViewActionPanelEventListener _viewActionPanelEventListener;
        private Builder.ActionPanel.Garden.Garden _gardenActionPanel;
        
        public View.Garden.IGarden GardenView { get; set; }
        public Model.Garden.Garden GardenModel { get; private set; }

        public Garden(NHibernate.ISession sx,
            HostFormSeperateActionPanel hostFormSeperateActionPanel)
        {
            _sx = sx;
            _HostFormSeperateActionPanel = hostFormSeperateActionPanel;
        }

        public void Show()
        {
            AttachViewToForm();
            BuildActionPanel();
        }

        public void BuildActionPanel()
        {
            _gardenActionPanel = new Builder.ActionPanel.Garden.Garden(_actionPanelView.ActionTableLayoutPanel);
            _gardenActionPanel.BuildGroupings();
            _gardenActionPanel.AddGroupings();
            _gardenActionPanel.Refresh();
        }

        public void RefreshAwardLists()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        private void AttachViewToForm()
        {
            GardenView = new View.Garden.Garden(_HostFormSeperateActionPanel.StatusStrip);
            var viewAttacher = new ViewAttacher();
            viewAttacher.Attach(GardenView, _HostFormSeperateActionPanel.MainPanel);
        }


    }
}
