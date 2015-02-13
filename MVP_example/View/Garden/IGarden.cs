using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVP_example.Builder.ActionPanel;
using MVP_example.Framework.DirtyChecker;
using MVP_example.View.Framework;

namespace MVP_example.View.Garden
{
    interface IGarden : IView, IDirtyCheckerView
    {
        string Name { get; set; }
        string Description { get; set; }
    }
}
