using System;

namespace MVP_example.Presenter.Garden
{
    class ViewActionPanelEventListener : Framework.IViewActionPanelEventListener
    {
        private readonly Builder.ActionPanel.Garden.Garden _builder;
        private readonly IGarden _presenter;

        public ViewActionPanelEventListener(IGarden presenter,
            Builder.ActionPanel.Garden.Garden builder)
        {
            _presenter = presenter;
            _builder = builder;
        }

        public void AddHandlers()
        {
            _builder.Save += Save;
        }

        private void Save(object sender, EventArgs eventArgs)
        {
            var viewReader = new ViewReader(_presenter.GardenModel, _presenter.GardenView);
            viewReader.UpdateModelToView();
            _presenter.Save();
            _presenter.GardenView.DirtyControlCheckerWithStatusStrip.ResetIsDirtyDueToSave();
        }
    }
}
