using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservationAndBillingSystem
{
   
    public partial class Mainform : Form
    {
        string title = "HOTELMANAGEMENTANDBILLINGSYSTEM";
        public Mainform()
        {
            
            InitializeComponent();
        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AddRoom g = new AddRoom();
            g.TopLevel = false;
            panel2.Controls.Add(g);
            g.BringToFront();
            g.Show();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Reservation g = new Reservation();
            g.TopLevel = false;
            panel2.Controls.Add(g);
            g.BringToFront();
            g.Show();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("YOU WANT TO LOGOUT?", title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Form1 f = new Form1();
                this.Hide();
                f.Show();
            }
            else if (dialogResult == DialogResult.No)
            {

            }

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Billingcs g = new Billingcs();
            g.TopLevel = false;
            panel2.Controls.Add(g);
            g.BringToFront();
            g.Show();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            Maintenance g = new Maintenance();
            g.TopLevel = false;
            panel2.Controls.Add(g);
            g.BringToFront();
            g.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            SETTINGS g = new SETTINGS();
            g.TopLevel = false;
            panel2.Controls.Add(g);
            g.BringToFront();
            g.Show();
        }
    }
}
