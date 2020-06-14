using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Blood_Donaters_club
{
    public partial class FormSignUp : Form
    {
        public FormSignUp()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmail.Text = String.Empty;
            txtPassword.Text = String.Empty;
            txtUsername.Text = String.Empty;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSignIn f2 = new FormSignIn();
            f2.ShowDialog();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "" || txtPassword.Text == "" || txtUsername.Text == "")
            {
                MessageBox.Show("Fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Click OK to continue ", "Done", MessageBoxButtons.OK, MessageBoxIcon.None);
                if (result == DialogResult.OK)
                {
                    this.Close();
                    FormDonorData f2 = new FormDonorData();
                    f2.ShowDialog();
                }
            }
        }
        private void FormSignUp_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '\u25CF';
        }
    }
}
