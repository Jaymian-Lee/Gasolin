using System;
using System.Linq;
using System.Windows.Forms;
using Gasolin.models;

namespace Gasolin.forms
{
    public partial class AddRefueling : Form
    {
        public AddRefueling()
        {
            InitializeComponent();
            LoadDropdowns();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            int vehicleId = (int)cmbVehicle.SelectedValue;
            int personId = (int)cmbPerson.SelectedValue;
            DateTime timeStamp = dtpTimeStamp.Value;
            int liters = int.Parse(txtLiters.Text);
            int currentKm = int.Parse(txtCurrentKm.Text);
            decimal amountEuro = decimal.Parse(txtAmountEuro.Text);

            // Debug prints
            Console.WriteLine($"VehicleId: {vehicleId}");
            Console.WriteLine($"PersonId: {personId}");
            Console.WriteLine($"TimeStamp: {timeStamp}");
            Console.WriteLine($"Liters: {liters}");
            Console.WriteLine($"CurrentKm: {currentKm}");
            Console.WriteLine($"AmountEuro: {amountEuro}");

            // Create Refuel object with correct IDs
            Refuel refuel = new Refuel(0, timeStamp, liters, currentKm, amountEuro, vehicleId, personId);

            refuel.Save();
            MessageBox.Show("Brandstof succesvol toegevoegd!");

            this.Hide();
            RefuelingForm refuelingForm = new RefuelingForm();
            refuelingForm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Landing landing = new Landing();
            landing.Show();
        }
    }
}
