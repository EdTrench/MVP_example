using System;
using System.Windows.Forms;

namespace MVP_example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sx = DataAccess.nHibernate.Factory.OpenSession();
            var gardenService = new Service.Garden.Garden(sx, sx.Get<Model.Garden.Garden>(1));
            gardenService.Show();
        }
    }
}