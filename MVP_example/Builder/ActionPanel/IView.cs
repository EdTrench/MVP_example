using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVP_example.Framework.UserControls;

namespace MVP_example.Builder.ActionPanel
{
    interface IView
    {
        HostPanel HostPanel { get; set; }
        void SetPanel(HostPanel hostPanel);
    }
}
