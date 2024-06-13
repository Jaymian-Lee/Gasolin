using System;
using System.Windows.Forms;
using Gasolin.models;

namespace Gasolin.forms
{
    public partial class ChangePerson : Form
    {
        private Person _person;

        public ChangePerson(Person person)
        {
            InitializeComponent();
            _person = person;
            LoadPersonData();
        }

        private void LoadPersonData()
        {
            txtGivenName.Text = _person.GivenName;
            txtFamilyName.Text = _person.FamilyName;
            txtBirthdate.Text = _person.Birthdate.ToShortDateString();
            txtDriverLicenceDate.Text = _person.DriverLicenseDate.ToShortDateString();
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

        private void btnClose2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Update the person object with the new values
            _person.GivenName = txtGivenName.Text;
            _person.FamilyName = txtFamilyName.Text;
            _person.Birthdate = DateTime.Parse(txtBirthdate.Text);
            _person.DriverLicenseDate = DateTime.Parse(txtDriverLicenceDate.Text);

            // Save the updated person
            _person.Update();

            // Close the form
            this.Close();
        }
    }
}
