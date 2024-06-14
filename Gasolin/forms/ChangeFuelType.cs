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
    public partial class ChangeFuelType : Form
    {
        private FuelType _fuelType;
        public ChangeFuelType(FuelType fuelType)
        {
            _fuelType = fuelType;
            InitializeComponent();
            LoadFuelType();
        }

        private void LoadFuelType()
        {
            txtDescription.Text = _fuelType.Description;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _fuelType.Description = txtDescription.Text;
            _fuelType.Save();
            MessageBox.Show("Fuel Type updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void btnClose2_Click(object sender, EventArgs e)
        {
            RefuelingForm refuelingForm = new RefuelingForm();
            refuelingForm.Show();
            this.Hide();
        }

        private void btnClose1_Click(object sender, EventArgs e)
        {
            RefuelingForm refuelingForm = new RefuelingForm();
            refuelingForm.Show();
            this.Hide();
        }
    }
}
