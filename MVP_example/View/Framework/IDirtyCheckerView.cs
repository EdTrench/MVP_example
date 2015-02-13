using System;
using System.Windows.Forms;
using MVP_example.Framework.DirtyChecker;

namespace MVP_example.View.Framework
{
    interface IDirtyCheckerView
    {
        DirtyControlCheckerWithStatusStrip DirtyControlCheckerWithStatusStrip { get; set; }
        event EventHandler InformUserOfDirtyView;
        event EventHandler<FormClosingEventArgs> InformUserOfDirtyViewFormClosing;
        event EventHandler SaveCompletedEventHandler;
    }
}
