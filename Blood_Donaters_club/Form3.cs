using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Donaters_club
{
    public partial class FormDonorData : Form
    {
        public FormDonorData()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void formDonatorData_Load(object sender, EventArgs e)
        {

        }

        private void btnChangeUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSignUp f2 = new FormSignUp();
            f2.ShowDialog();
        }
    }
}
