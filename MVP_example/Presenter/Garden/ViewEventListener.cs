using System;
using System.Windows.Forms;

namespace MVP_example.Presenter.Garden
{
    class ViewEventListener : Framework.IViewEventListener
    {
        private readonly View.Garden.IGarden _view;
        private readonly IGarden _presenter;

        public ViewEventListener(IGarden presenter)
        {
            _presenter = presenter;
            _view = presenter.GardenView;
        }

        public void AddHandlers()
        {
            _view.InformUserOfDirtyViewFormClosing += InformUserOfDirtyView;
        }

        private void InformUserOfDirtyView(object o, FormClosingEventArgs eventArgs)
        {
            switch (MessageBox.Show("You have made one or more changes, do you wish to save?", "Garden", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    try
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        var viewReader = new ViewReader(_presenter.GardenModel, _presenter.GardenView);
                        viewReader.UpdateModelToView();
                        _presenter.Save();
                    }
                    finally
                    {
                        Cursor.Current = Cursors.Default;
                    }
                    break;
                case DialogResult.Cancel:
                    eventArgs.Cancel = true;
                    break;
            }
        }
    }
}
