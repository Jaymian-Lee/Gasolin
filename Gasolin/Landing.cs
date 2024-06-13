using Gasolin.forms;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gasolin
{
    public partial class Landing : Form
    {
        public Landing()
        {
            InitializeComponent();
            InitializeListView(); // Initialiseer de ListView kolommen
            InitializeListViewCars(); // Initialiseer de ListView kolommen
            LoadPeople(); // Laad de mensenlijst direct na het initialiseren van de componenten
            LoadCars();
        }

        private void btnPerson_Click(object sender, EventArgs e)
        {
            this.Hide();
            PersonForm personForm = new PersonForm();
            personForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Landing landing = new Landing();
            landing.Show();
            this.Hide();
        }

        private void btnTank_Click_1(object sender, EventArgs e)
        {
            RefuelingForm refuelingForm = new RefuelingForm();
            refuelingForm.Show();
            this.Hide();
        }

        private void btnCars_Click_1(object sender, EventArgs e)
        {
            CarsForm carsForm = new CarsForm();
            carsForm.Show();
            this.Hide();
        }

        private void lstPerson_SelectedIndexChanged(object sender, EventArgs e)
        {
        }


        private void InitializeListView()
        {
            lstPerson.View = View.Details;
            lstPerson.FullRowSelect = true; // Zorg ervoor dat hele rijen worden geselecteerd
            lstPerson.Columns.Add("Id", 50, HorizontalAlignment.Left);
            lstPerson.Columns.Add("Voornaam", 100, HorizontalAlignment.Left);
            lstPerson.Columns.Add("Achternaam", 100, HorizontalAlignment.Left);
            lstPerson.Columns.Add("Geboortedatum", 100, HorizontalAlignment.Left);
            lstPerson.Columns.Add("Rijbewijs behaald", 100, HorizontalAlignment.Left);
        }

        private void LoadPeople()
        {
            lstPerson.Items.Clear();  // Clear the ListView before reloading

            List<Person> people = Person.GetAll();
            foreach (var person in people)
            {
                ListViewItem item = new ListViewItem(person.Id.ToString());
                item.SubItems.Add(person.GivenName);
                item.SubItems.Add(person.FamilyName);
                item.SubItems.Add(person.Birthdate.ToShortDateString());
                item.SubItems.Add(person.DriverLicenseDate.ToShortDateString());
                item.Tag = person; // Store the person object in the ListViewItem's Tag property
                lstPerson.Items.Add(item);
            }
        }

        private void InitializeListViewCars()
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

        private void lstCars_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
