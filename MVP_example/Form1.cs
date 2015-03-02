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
            var garden = new Model.Garden.Garden {Id = 1, Description = "Test Description", Name = "Test Name"};
            var gardenService = new Service.Garden.Garden(sx, garden);
            gardenService.Show();
        }
    }
}