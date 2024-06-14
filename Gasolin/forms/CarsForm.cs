using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Gasolin.models;

namespace Gasolin.forms
{
    public partial class CarsForm : Form
    {
        public CarsForm()
        {
            InitializeComponent();
            InitializeListView();
            LoadVehicleType();
            InitializeListViewVehicleType();
            LoadCars();
        }

        private void btnPerson_Click(object sender, EventArgs e)
        {
            PersonForm personForm = new PersonForm();
            personForm.Show();
            this.Hide();
        }

        private void btnTank_Click(object sender, EventArgs e)
        {
            RefuelingForm refuelingForm = new RefuelingForm();
            refuelingForm.Show();
            this.Hide();
        }

        private void CarsButton_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Landing landing = new Landing();
            landing.Show();
            this.Hide();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            AddCars addCarsForm = new AddCars();
            addCarsForm.Show();
            this.Hide();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // No action needed here
        }

        private void InitializeListView()
        {
            lstCars.View = View.Details;
            lstCars.FullRowSelect = true;
            lstCars.Columns.Add("LicensePlate", 100, HorizontalAlignment.Left);
            lstCars.Columns.Add("Description", 150, HorizontalAlignment.Left);
            lstCars.Columns.Add("Type", 100, HorizontalAlignment.Left);
            lstCars.Columns.Add("ConstructionYear", 100, HorizontalAlignment.Left);
            lstCars.Columns.Add("PurchaseDate", 100, HorizontalAlignment.Left);
            lstCars.Columns.Add("InitialKm", 100, HorizontalAlignment.Left);
            lstCars.Columns.Add("SaleDate", 100, HorizontalAlignment.Left);
            lstCars.Columns.Add("Active", 50, HorizontalAlignment.Left);
            lstCars.Columns.Add("Fuel", 50, HorizontalAlignment.Left);
        }

        private void LoadCars()
        {
            lstCars.Items.Clear();

            List<Vehicle> vehicles = Vehicle.GetAll();
            foreach (var vehicle in vehicles)
            {
                ListViewItem item = new ListViewItem(vehicle.LicensePlate);
                item.SubItems.Add(vehicle.Description);
                item.SubItems.Add(vehicle.Type);
                item.SubItems.Add(vehicle.ConstructionYear.ToString());
                item.SubItems.Add(vehicle.PurchaseDate.ToShortDateString());
                item.SubItems.Add(vehicle.InitialKm.ToString());
                item.SubItems.Add(vehicle.SaleDate?.ToShortDateString() ?? "");
                item.SubItems.Add(vehicle.Active.ToString());
                item.SubItems.Add(vehicle.Fuel);
                item.Tag = vehicle;
                lstCars.Items.Add(item);
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (lstCars.SelectedItems.Count > 0)
            {
                ListViewItem item = lstCars.SelectedItems[0];
                Vehicle selectedVehicle = (Vehicle)item.Tag;

                ChangeCars changeCarsForm = new ChangeCars(selectedVehicle);
                changeCarsForm.ShowDialog();

                LoadCars();
            }
        }

        private void btnRemove_Click_1(object sender, EventArgs e)
        {
            if (lstCars.SelectedItems.Count > 0)
            {
                ListViewItem item = lstCars.SelectedItems[0];
                Vehicle selectedVehicle = (Vehicle)item.Tag;

                selectedVehicle.Delete();
                LoadCars();
            }
        }

        private void btnAddVehicleType_Click(object sender, EventArgs e)
        {
            AddVehicleType addVehicleType = new AddVehicleType();
            addVehicleType.Show();
            this.Hide();
        }

        private void btnChangeVehicleType_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoveVehicleType_Click(object sender, EventArgs e)
        {

        }

        private void lstVehicleType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void InitializeListViewVehicleType()
        {
            lstVehicleType.View = View.Details;
            lstVehicleType.FullRowSelect = true;
            lstVehicleType.Columns.Add("Id", 30, HorizontalAlignment.Left);
            lstVehicleType.Columns.Add("Beschrijving", 140, HorizontalAlignment.Left);
        }

        private void LoadVehicleType()
        {
            lstVehicleType.Items.Clear();

            List<VehicleType> vehicleTypes = VehicleType.GetAll();
            foreach (var vehicleType in vehicleTypes)
            {
                ListViewItem item = new ListViewItem(vehicleType.Id.ToString());
                item.SubItems.Add(vehicleType.Description);
                item.Tag = vehicleType;
                lstVehicleType.Items.Add(item);
            }
        }
    }
}