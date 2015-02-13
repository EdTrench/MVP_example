using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_example.Framework.DirtyChecker
{
    public class DirtyControlChecker
    {
        public bool IsDirty { get; private set; }

        public virtual void ResetIsDirty()
        {
            IsDirty = false;
        }

        public void AddDirtyEvent(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c.GetType() == typeof(TextBox)) { c.TextChanged += MakeDirty; }
                if (c.GetType() == typeof(RichTextBox)) { c.TextChanged += MakeDirty; }
                if (c.GetType() == typeof(ComboBox))
                {
                    var comboBox = (ComboBox)c;
                    comboBox.SelectedIndexChanged += MakeDirty;
                }
                if (c.GetType() == typeof(DateTimePicker))
                {
                    var dateTimePicker = (DateTimePicker)c;
                    dateTimePicker.ValueChanged += MakeDirty;
                }
                if (c.GetType() == typeof(CheckBox))
                {
                    var checkbox = (CheckBox)c;
                    checkbox.CheckStateChanged += MakeDirty;
                }
                AddEventToSubControls(c);
            }
        }

        private void AddEventToSubControls(Control control)
        {
            if (control.Controls.Count > 0) { AddDirtyEvent(control); }
        }

        protected virtual void MakeDirty(Object sender, EventArgs e)
        {
            IsDirty = true;
        }

        public virtual void MakeDirtyManual()
        {
            IsDirty = true;
        }        
    }
}