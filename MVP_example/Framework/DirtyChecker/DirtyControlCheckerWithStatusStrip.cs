using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP_example.Framework.DirtyChecker
{
    public class DirtyControlCheckerWithStatusStrip : DirtyControlChecker
    {

        private readonly StatusStrip _statusStrip;

        public DirtyControlCheckerWithStatusStrip(StatusStrip statusStrip)
        {
            _statusStrip = statusStrip;
        }

        public override void ResetIsDirty()
        {
            base.ResetIsDirty();
            _statusStrip.Items.Clear();
            _statusStrip.Items.Add(new ToolStripStatusLabel("Ready."));
        }

        public void ResetIsDirtyDueToSave()
        {
            base.ResetIsDirty();
            _statusStrip.Items.Clear();
            _statusStrip.Items.Add(new ToolStripStatusLabel("Saved."));
        }

        protected override void MakeDirty(object sender, EventArgs e)
        {
            base.MakeDirty(sender, e);
            _statusStrip.Items.Clear();
            _statusStrip.Items.Add(new ToolStripStatusLabel("Not Saved."));
        }

        public override void MakeDirtyManual()
        {
            base.MakeDirtyManual();
            _statusStrip.Items.Clear();
            _statusStrip.Items.Add(new ToolStripStatusLabel("Not Saved."));
        }
    }
}