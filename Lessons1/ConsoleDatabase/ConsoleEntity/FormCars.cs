using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleEntity
{
    public partial class FormCars : Form
    {
        protected AutoLotEntities context = new AutoLotEntities();
        public FormCars()
        {
            InitializeComponent();
        }

        private void FormCars_Load(object sender, EventArgs e)
        {
            //gridCars.DataSource = context.Cars;
        }

        private void FormCars_FormClosed(object sender, FormClosedEventArgs e)
        {
            context.Dispose();
        }
    }
}
