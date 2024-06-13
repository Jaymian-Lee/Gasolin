using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gasolin.forms
{
    public partial class RefuelingForm : Form
    {
        public RefuelingForm()
        {
            InitializeComponent();
        }

        private void btnPerson_Click(object sender, EventArgs e)
        {
            PersonForm personForm = new PersonForm();
            personForm.Show();
            Close();

        }

        private void btnCars_Click(object sender, EventArgs e)
        {
            CarsForm carForm = new CarsForm();
            carForm.Show();
            Close();
        }

        private void btnTank_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Landing landing = new Landing();
            landing.Show();
            Close();
        }

        private void lstPeople_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
