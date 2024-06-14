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
    public partial class AddFuelType : Form
    {
        public AddFuelType()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FuelType newFuelType = new FuelType
            {
                Description = txtDescription.Text,
            };

            newFuelType.Save();

            this.Hide();
            RefuelingForm refuelingForm = new RefuelingForm();
            refuelingForm.Show();
        }

        private void btnClose2_Click(object sender, EventArgs e)
        {
            this.Hide();
            RefuelingForm refuelingForm = new RefuelingForm();
            refuelingForm.Show();
        }

        private void btnClose1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RefuelingForm refuelingForm = new RefuelingForm();
            refuelingForm.Show();
        }
    }
}
