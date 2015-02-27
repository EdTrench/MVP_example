using System;
using FluentNHibernate.Mapping;
using MVP_example.Framework.Forms.Base_Forms;
using MVP_example.Presenter.Framework;
using NHibernate.Mapping.ByCode.Impl;

namespace MVP_example.Presenter.Garden
{
    internal class Garden : IGarden
    {

        protected readonly HostFormSeperateActionPanel _hostFormSeperateActionPanel;
        protected readonly NHibernate.ISession _sx;

        private Builder.ActionPanel.View _actionPanelView;
        private Builder.ActionPanel.Garden.Garden _gardenActionPanel;
        private Framework.IViewEventListener _viewEventListener;
        private Framework.IViewActionPanelEventListener _viewActionPanelEventListener;
        private Service.Garden.Garden _gardenService;

        public View.Garden.IGarden GardenView { get; set; }
        public Model.Garden.Garden GardenModel { get; private set; }

        public Garden(NHibernate.ISession sx,
            HostFormSeperateActionPanel hostFormSeperateActionPanel,
            Service.Garden.Garden gardenService)
        {
            _sx = sx;
            _hostFormSeperateActionPanel = hostFormSeperateActionPanel;
            _gardenService = gardenService;
        }

        public void Show()
        {
            AttachViewToForm();
            AttachActionPanelToForm();
            BuildActionPanel();
            //SetListViewBuilders();
            CreateEventListener();
            CreateActionPanelEventListener();
            AddViewEventHandlers();
            AddActionPanelEventHandlers();
            //PopulateListsInView();
            PopulateView();
            _hostFormSeperateActionPanel.ShowDialog();
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
            using (NHibernate.ITransaction tx = _sx.BeginTransaction())
            {
                _gardenService.Save();
                tx.Commit();
            }
        }

        private void AttachViewToForm()
        {
            GardenView = new View.Garden.Garden(_hostFormSeperateActionPanel.StatusStrip);
            var viewAttacher = new ViewAttacher();
            viewAttacher.Attach(GardenView, _hostFormSeperateActionPanel.MainPanel);
        }

        private void AttachActionPanelToForm()
        {
            _actionPanelView = new Builder.ActionPanel.View();
            var viewAttacher = new Framework.ViewAttacher();
            viewAttacher.Attach(_actionPanelView, _hostFormSeperateActionPanel.ActionPanel);
        }

        private void CreateEventListener()
        {
            _viewEventListener = new ViewEventListener(this);
        }

        private void CreateActionPanelEventListener()
        {
            _viewActionPanelEventListener = new ViewActionPanelEventListener(this, _gardenActionPanel);
        }

        private void AddViewEventHandlers()
        {
            _viewEventListener.AddHandlers();
        }

        private void AddActionPanelEventHandlers()
        {
            _viewActionPanelEventListener.AddHandlers();
        }

        private void PopulateView()
        {
            var viewPopulator = new ViewPopulator(GardenModel, GardenView);
            viewPopulator.Populate();
        }
    }
}
