﻿using Gasolin.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gasolin
{
    public partial class Landing : Form
    {
        public Landing()
        {
            InitializeComponent();
        }

        private void btnPerson_Click(object sender, EventArgs e)
        {
            this.Hide();
            PersonForm personForm = new PersonForm();
            personForm.Show();
        }

        private void btnCars_Click(object sender, EventArgs e)
        {
            CarsForm carForm = new CarsForm();
            carForm.Show();
            Close();
        }

        private void btnTank_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Landing landing = new Landing();
            landing.Show();
            Close();
        }
    }
}
