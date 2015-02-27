namespace MVP_example.Presenter.Garden
{
    class ViewReader : Framework.ViewReader
    {

        private readonly Model.Garden.Garden _garden;
        private readonly View.Garden.IGarden _view;

        public ViewReader(Model.Garden.Garden garden,
            View.Garden.IGarden view)
        {
            _garden = garden;
            _view = view;
        }

        public override void UpdateModelToView()
        {
            _garden.Description = _view.Description;
            _garden.Name = _view.Name;
        }
    }
}
