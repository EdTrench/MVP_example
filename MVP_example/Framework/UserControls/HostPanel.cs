using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP_example.Framework.UserControls
{
    public class HostPanel : Panel
    {
        private Form _parentForm;
        private Control _controlCache;

        public delegate void ControlChanged();
        public delegate void ParentFormClosing(FormClosingEventArgs e);

        public event ControlChanged UserControlChanged;
        public event ParentFormClosing parentClosing;

        public void Initialise()
        {
            _parentForm = this.FindForm();
            _parentForm.FormClosing += FormClosing;
        }

        public void AddUserControl(UserControl userControl)
        {
            if (Controls.Count == 0)
            {
                AddControl(userControl);
            }
            else if (Controls.Count == 1)
            {
                _controlCache = Controls[0];
                UserControlChanged();
                Controls.Clear();
                AddControl(userControl);
            }
            else if (Controls.Count > 1)
            {
                throw new InvalidOperationException();       
            }
        }

        private void AddControl(Control control)
        {
            Controls.Clear();
            Controls.Add(_controlCache);
        }

        private void FormClosing(Object sender, FormClosingEventArgs e)
        {
            parentClosing(e);
        }

    }
}
