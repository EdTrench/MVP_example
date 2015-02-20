using MVP_example.Builder.ActionPanel;
using MVP_example.Framework.UserControls;

namespace MVP_example.Presenter.Framework
{
    class ViewAttacher
    {
        public void Attach(IView view, HostPanel hostPanel)
        {
            view.SetPanel(hostPanel);
        }
    }
}