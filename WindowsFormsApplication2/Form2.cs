using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Administator = "tbw";
            string Password = "1234";


            if (textBox1.Text == Administator && textBox2.Text == Password)
            {
                Form3 F3 = new Form3();
                this.Hide();
                F3.Show();
            }

            else { MessageBox.Show("Admin Name Or Password Incorrect. Please Check And Try Again!"); }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string User_Name = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string password = textBox2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 F1 = new Form1();
            this.Hide();
            F1.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form1 F1 = new Form1();
            this.Hide();
            F1.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
