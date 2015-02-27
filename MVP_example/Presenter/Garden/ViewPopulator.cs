namespace MVP_example.Presenter.Garden
{
    class ViewPopulator : Framework.ViewPopulator
    {
        private readonly Model.Garden.Garden _garden;
        private readonly View.Garden.IGarden _view;

        public ViewPopulator(Model.Garden.Garden garden,
            View.Garden.IGarden view)
        {
            _garden = garden;
            _view = view;
        }

        public override void Populate()
        {
            _view.Description = _garden.Description;
            _view.Name = _garden.Name;
            _view.DirtyControlCheckerWithStatusStrip.ResetIsDirty();
        }
    }
}