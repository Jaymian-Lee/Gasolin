using System;
using System.Windows.Forms;
using Gasolin.models;

namespace Gasolin.forms
{
    public partial class AddCars : Form
    {
        public AddCars()
        {
            InitializeComponent();
        }

        private void btnClose1_Click_1(object sender, EventArgs e)
        {
            CarsForm carsForm = new CarsForm();
            carsForm.Show();
            this.Close();
        }

        private void btnClose2_Click_1(object sender, EventArgs e)
        {
            CarsForm carsForm = new CarsForm();
            carsForm.Show();
            this.Close();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            int constructionYear;
            DateTime purchaseDate;
            DateTime? saleDate = null;
            DateTime parsedSaleDate = DateTime.MinValue; // Initialize parsedSaleDate here
            int initialKm;
            int active;
            string fuel;

            if (!int.TryParse(txtConstructionDate.Text, out constructionYear))
            {
                MessageBox.Show("Voer een geldig constructiejaar in (YYYY).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!DateTime.TryParse(txtPurchaseDate.Text, out purchaseDate))
            {
                MessageBox.Show("Voer een geldige tennaamstelling in (YYYY-MM-DD).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!string.IsNullOrEmpty(txtSaleDate.Text) && !DateTime.TryParse(txtSaleDate.Text, out parsedSaleDate))
            {
                MessageBox.Show("Voer een geldige verkoopdatum in (YYYY-MM-DD) of laat het veld leeg.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!string.IsNullOrEmpty(txtSaleDate.Text))
            {
                saleDate = parsedSaleDate;
            }

            if (!int.TryParse(txtInitialKm.Text, out initialKm))
            {
                MessageBox.Show("Voer een geldige kilometerstand in.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtActive.Text, out active))
            {
                MessageBox.Show("Voer een geldige waarde voor actief in (true/false).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtFuel.Text))
            {
                MessageBox.Show("Voer een geldige waarde voor brandstof in.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Vehicle newVehicle = new Vehicle
            {
                LicensePlate = txtLicensePlate.Text,
                Description = txtDescription.Text,
                Type = txtCarType.Text,
                ConstructionYear = constructionYear,
                PurchaseDate = purchaseDate,
                InitialKm = initialKm,
                SaleDate = saleDate,
                Active = active,
                Fuel = txtFuel.Text,
                Brand = txtBrand.Text
            };

            newVehicle.Save();

            CarsForm carsForm = new CarsForm();
            carsForm.Show();
            this.Close();
        }
    }
}
