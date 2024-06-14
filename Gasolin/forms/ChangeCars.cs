using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Gasolin.models;

namespace Gasolin.forms
{
    public partial class ChangeCars : Form
    {
        private Vehicle _vehicle;

        public ChangeCars(Vehicle vehicle)
        {
            InitializeComponent();
            _vehicle = vehicle;
            LoadVehicleTypes();
            LoadVehicleData();
        }

        private void LoadVehicleTypes()
        {
            List<VehicleType> vehicleTypes = VehicleType.GetAll();
            cmbVehicleType.DataSource = vehicleTypes;
            cmbVehicleType.DisplayMember = "Description";
            cmbVehicleType.ValueMember = "Id";
        }

        private void LoadVehicleData()
        {
            txtLicensePlate.Text = _vehicle.LicensePlate;
            txtDescription.Text = _vehicle.Description;
            cmbVehicleType.SelectedValue = _vehicle.Type;
            txtConstructionDate.Text = _vehicle.ConstructionYear.ToString();
            txtPurchaseDate.Text = _vehicle.PurchaseDate.ToShortDateString();
            txtInitialKm.Text = _vehicle.InitialKm.ToString();
            txtSaleDate.Text = _vehicle.SaleDate?.ToShortDateString() ?? "";
            txtActive.Text = _vehicle.Active.ToString();
            txtFuel.Text = _vehicle.Fuel.ToString();
            txtBrand.Text = _vehicle.Brand;
            txtOwners.Text = _vehicle.Owners;
            txtRefills.Text = _vehicle.Refills;
        }

        private void btnClose1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int constructionYear;
            DateTime purchaseDate;
            DateTime? saleDate = null;
            DateTime parsedSaleDate = DateTime.MinValue; // Initialize parsedSaleDate here
            int initialKm;
            int active;

            if (!int.TryParse(txtConstructionDate.Text, out constructionYear))
            {
                MessageBox.Show("Voer een geldig constructiejaar in (YYYY).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!DateTime.TryParse(txtPurchaseDate.Text, out purchaseDate))
            {
                MessageBox.Show("Voer een geldige aankoopdatum in (YYYY-MM-DD).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            _vehicle.LicensePlate = txtLicensePlate.Text;
            _vehicle.Description = txtDescription.Text;
            _vehicle.Type = cmbVehicleType.SelectedValue.ToString(); // Gebruik het geselecteerde voertuigtype
            _vehicle.ConstructionYear = constructionYear;
            _vehicle.PurchaseDate = purchaseDate;
            _vehicle.InitialKm = initialKm;
            _vehicle.SaleDate = saleDate;
            _vehicle.Active = active;
            _vehicle.Fuel = txtFuel.Text;
            _vehicle.Brand = txtBrand.Text;
            _vehicle.Owners = txtOwners.Text;
            _vehicle.Refills = txtRefills.Text;

            _vehicle.Update();

            this.Close();
        }

        private void cmbVehicleType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
