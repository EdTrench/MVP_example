using System;

namespace MVP_example.Service.Garden
{
    class Garden
    {
        private readonly NHibernate.ISession _sx;
        private readonly Model.Garden.Garden _garden;

        public Garden(NHibernate.ISession sx,
            Model.Garden.Garden garden)
        {
            _sx = sx;
            _garden = garden;
        }

        public void Show()
        {
            var hostForm = new Framework.Forms.Base_Forms.HostFormSeperateActionPanel(String.Format("Garden {0}", _garden.Id));
            var presenter = new Presenter.Garden.Garden(_sx, hostForm, _garden);
            presenter.Show();
        }

        public void ShowForAdd()
        {
            
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
