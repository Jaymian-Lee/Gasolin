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

        }

        private void btnClose1_Click(object sender, EventArgs e)
        {
            PersonForm personForm = new PersonForm();
            personForm.Show();
            Close();
        }
    }
}
