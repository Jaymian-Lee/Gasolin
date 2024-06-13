using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Gasolin.models;

namespace Gasolin.forms
{
    public partial class PersonForm : Form
    {
        public PersonForm()
        {
            InitializeComponent();
            InitializeListView(); // Initialiseer de ListView kolommen
            LoadPeople(); // Laad de mensenlijst direct na het initialiseren van de componenten
        }

        private void btnTank_Click(object sender, EventArgs e)
        {
            RefuelingForm form = new RefuelingForm();
            form.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Landing landing = new Landing();
            landing.Show();
            this.Hide();
        }

        private void btnPerson_Click(object sender, EventArgs e)
        {

        }

        private void btnCars_Click(object sender, EventArgs e)
        {
            CarsForm carsForm = new CarsForm();
            carsForm.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddPerson addPerson = new AddPerson();
            addPerson.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lstCars.SelectedItems.Count > 0)
            {
                ListViewItem item = lstCars.SelectedItems[0];
                Person selectedPerson = (Person)item.Tag;

                // Open the ChangePerson form with the selected person
                ChangePerson changePersonForm = new ChangePerson(selectedPerson);
                changePersonForm.ShowDialog();

                // Reload the people list after closing the ChangePerson form
                LoadPeople();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstCars.SelectedItems.Count > 0)
            {
                ListViewItem item = lstCars.SelectedItems[0];
                Person selectedPerson = (Person)item.Tag;

                selectedPerson.Delete();
                LoadPeople();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Deze methode kan leeg blijven als we alleen willen dat de lijst wordt geladen bij het laden van het formulier
        }

        private void InitializeListView()
        {
            lstCars.View = View.Details;
            lstCars.FullRowSelect = true; // Zorg ervoor dat hele rijen worden geselecteerd
            lstCars.Columns.Add("Id", 50, HorizontalAlignment.Left);
            lstCars.Columns.Add("GivenName", 100, HorizontalAlignment.Left);
            lstCars.Columns.Add("FamilyName", 100, HorizontalAlignment.Left);
            lstCars.Columns.Add("Birthdate", 100, HorizontalAlignment.Left);
            lstCars.Columns.Add("DriverLicenseDate", 100, HorizontalAlignment.Left);
        }

        private void LoadPeople()
        {
            lstCars.Items.Clear();  // Clear the ListView before reloading

            List<Person> people = Person.GetAll();
            foreach (var person in people)
            {
                ListViewItem item = new ListViewItem(person.Id.ToString());
                item.SubItems.Add(person.GivenName);
                item.SubItems.Add(person.FamilyName);
                item.SubItems.Add(person.Birthdate.ToShortDateString());
                item.SubItems.Add(person.DriverLicenseDate.ToShortDateString());
                item.Tag = person; // Store the person object in the ListViewItem's Tag property
                lstCars.Items.Add(item);
            }
        }
    }
}
