using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Gasolin.models;

namespace Gasolin.forms
{
    public partial class RefuelingForm : Form
    {
        public RefuelingForm()
        {
            InitializeComponent();
            InitializeListView();
            LoadRefuels();
        }
        private void InitializeListView()
        {
            lstRefuels.View = View.Details;
            lstRefuels.FullRowSelect = true;
            lstRefuels.GridLines = true;

            // Voeg kolommen toe aan de ListView
            lstRefuels.Columns.Add("ID", 50);
            lstRefuels.Columns.Add("TimeStamp", 120);
            lstRefuels.Columns.Add("Liters", 60);
            lstRefuels.Columns.Add("CurrentKm", 80);
            lstRefuels.Columns.Add("AmountEuro", 80);
            lstRefuels.Columns.Add("LicensePlate", 100);
            lstRefuels.Columns.Add("Person", 150);
        }
        private void LoadRefuels()
        {
            List<Refuel> refuels = Refuel.GetAll();
            lstRefuels.Items.Clear();

            foreach (var refuel in refuels)
            {
                ListViewItem item = new ListViewItem(refuel.Id.ToString());
                item.SubItems.Add(refuel.TimeStamp.ToString());
                item.SubItems.Add(refuel.Liters.ToString());
                item.SubItems.Add(refuel.CurrentKm.ToString());
                item.SubItems.Add(refuel.AmountEuro.ToString("C"));
                item.SubItems.Add(refuel.RefueledVehicle.LicensePlate);
                item.SubItems.Add(refuel.PersonThatRefueled.GivenName + " " + refuel.PersonThatRefueled.FamilyName);
                lstRefuels.Items.Add(item);
            }
        }

        private void btnAddRefuel_Click(object sender, EventArgs e)
        {
            AddRefueling addRefuelingForm = new AddRefueling();
            addRefuelingForm.Show();
            this.Hide();
        }

        private void btnPerson_Click(object sender, EventArgs e)
        {
            PersonForm personForm = new PersonForm();
            personForm.Show();
            Close();
        }

        private void btnCars_Click(object sender, EventArgs e)
        {
            CarsForm carForm = new CarsForm();
            carForm.Show();
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Landing landing = new Landing();
            landing.Show();
            Close();
        }

        private void lstRefuels_DoubleClick(object sender, EventArgs e)
        {
            if (lstRefuels.SelectedItems.Count > 0)
            {
                int refuelId = int.Parse(lstRefuels.SelectedItems[0].Text);
                Refuel refuel = Refuel.GetAll().FirstOrDefault(r => r.Id == refuelId);

                if (refuel != null)
                {
                    ChangeRefueling changeRefuelingForm = new ChangeRefueling(refuel);
                    changeRefuelingForm.Show();
                }
            }
        }


        private void lstRefuels_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstRefuels_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dubbel klik op een record om hem te bewerken!", "Aanpassen");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PersonForm form = new PersonForm();
            form.ShowDialog();
        }

        private void CarsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CarsForm form = new CarsForm();
            form.ShowDialog();
        }

        private void btnTank_Click(object sender, EventArgs e)
        {
            this.Hide();
            RefuelingForm form = new RefuelingForm();
            form.ShowDialog();
        }
    }
}
