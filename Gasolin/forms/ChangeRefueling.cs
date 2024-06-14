using System;
using System.Linq;
using System.Windows.Forms;
using Gasolin.models;

namespace Gasolin.forms
{
    public partial class ChangeRefueling : Form
    {
        private Refuel _refuel;

        public ChangeRefueling(Refuel refuel)
        {
            InitializeComponent();
            _refuel = refuel;
            LoadDropdowns();
            LoadRefuelData();
        }

        private void LoadDropdowns()
        {
            cmbVehicle.DataSource = Vehicle.GetAll();
            cmbVehicle.DisplayMember = "LicensePlate";
            cmbVehicle.ValueMember = "Id";

            cmbPerson.DataSource = Person.GetAll();
            cmbPerson.DisplayMember = "GivenName";
            cmbPerson.ValueMember = "Id";
        }

        private void LoadRefuelData()
        {
            cmbVehicle.SelectedValue = _refuel.VehicleId;
            cmbPerson.SelectedValue = _refuel.PersonId;
            dtpTimeStamp.Value = _refuel.TimeStamp;
            txtLiters.Text = _refuel.Liters.ToString();
            txtCurrentKm.Text = _refuel.CurrentKm.ToString();
            txtAmountEuro.Text = _refuel.AmountEuro.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _refuel.VehicleId = (int)cmbVehicle.SelectedValue;
            _refuel.PersonId = (int)cmbPerson.SelectedValue;
            _refuel.TimeStamp = dtpTimeStamp.Value;
            _refuel.Liters = int.Parse(txtLiters.Text);
            _refuel.CurrentKm = int.Parse(txtCurrentKm.Text);
            _refuel.AmountEuro = decimal.Parse(txtAmountEuro.Text);

            _refuel.Save();
            MessageBox.Show("Refueling updated successfully!");

            this.Hide();
            RefuelingForm refuelingForm = new RefuelingForm();
            refuelingForm.Show();
        }

        private void ChangeRefueling_Load(object sender, EventArgs e)
        {
            LoadRefuelData();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Landing landing = new Landing();
            landing.Show();
        }
    }
}
