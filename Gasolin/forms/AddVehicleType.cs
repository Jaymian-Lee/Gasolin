using Gasolin.models;
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
    public partial class AddVehicleType : Form
    {
        public AddVehicleType()
        {
            InitializeComponent();
        }

        private void btnClose1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CarsForm carsForm = new CarsForm();
            carsForm.Show();
        }

        private void btnClose2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CarsForm carsForm = new CarsForm();
            carsForm.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            VehicleType newVehicleType = new VehicleType
            {
                Description = txtDescription.Text,
            };

            newVehicleType.Save();

            this.Hide();
            CarsForm carsForm = new CarsForm();
            carsForm.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Landing landing = new Landing();
            landing.Show();
        }
    }
}
