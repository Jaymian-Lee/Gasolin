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
    public partial class AddPerson : Form
    {
        public AddPerson()
        {
            InitializeComponent();
        }

        private void btnClose2_Click(object sender, EventArgs e)
        {
            PersonForm personForm = new PersonForm();
            personForm.Show();
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Maak een nieuwe persoon aan op basis van de ingevoerde gegevens
            Person newPerson = new Person(
                id: 0,  // De ID kan automatisch gegenereerd worden door de database, dus 0 of een andere placeholder
                givenName: txtGivenName.Text,
                familyName: txtFamilyName.Text,
                birthDate: DateTime.Parse(txtBirthdate.Text),
                driverLicenseDate: DateTime.Parse(txtDriverLicenceDate.Text)
            );

            newPerson.Save();

            // Keer terug naar het PersonForm
            PersonForm personForm = new PersonForm();
            personForm.Show();
            Close();
        }

        private void btnClose1_Click(object sender, EventArgs e)
        {
            PersonForm personForm = new PersonForm();
            personForm.Show();
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtGivenName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFamilyName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBirthdate_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDriverLicenceDate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
