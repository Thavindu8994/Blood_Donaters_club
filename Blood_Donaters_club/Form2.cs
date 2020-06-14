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
    public partial class FormSignIn : Form
    {
        public FormSignIn()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lnklblCreateAnAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            FormSignUp f1 = new FormSignUp();
            f1.ShowDialog();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "" || txtUsername.Text == "")
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

        private void FormSignIn_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '\u25CF';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtUsername.Text = "";
        }
    }
}
