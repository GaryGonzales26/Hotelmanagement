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


namespace HotelReservationAndBillingSystem
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
          

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }
        private void guna2CheckBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (guna2CheckBox1.Checked)
            {
                textboxpass.UseSystemPasswordChar = false;

            }
            else
            {
                textboxpass.UseSystemPasswordChar = true;
            }
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            if (textboxuser.Text == "Admin" && textboxpass.Text == "Admin")
            {
                labelerror.Visible = false;
                Mainform f = new Mainform();
                this.Hide();
                f.Show();
            }
            else
            {
                labelerror.Visible = true;
                textboxpass.Clear();
            }
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void textboxuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void guna2CirclePictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
