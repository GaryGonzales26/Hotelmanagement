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
    public partial class Billingcs : Form
    {
        Database db = new Database();
        String query;
        public Billingcs()
        {
            InitializeComponent();
        }

        private void Billingcs_Load(object sender, EventArgs e)
        {
            query = "Select Reservation.id,Reservation.Fullname,Reservation.Mnumber,Reservation.Addres,Reservation.Gender,Reservation.CI,AddingRooms.RoomNo,AddingRooms.RoomType,AddingRooms.Beds,AddingRooms.Price From Reservation inner join AddingRooms on Reservation.RoomId = AddingRooms.RoomId where Scheckout = 'NO'";
            DataSet ds = db.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textboxname_TextChanged(object sender, EventArgs e)
        {
            query = "Select Reservation.id,Reservation.Fullname,Reservation.Mnumber,Reservation.Addres,Reservation.Gender,Reservation.CI,AddingRooms.RoomNo,AddingRooms.RoomType,AddingRooms.Beds,AddingRooms.Price From Reservation inner join AddingRooms on Reservation.RoomId = AddingRooms.RoomId where Fullname like '"+ textboxname.Text + "%' and Scheckout = 'NO'";
            DataSet ds = db.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        int id;
        private void Btncheckout_Click(object sender, EventArgs e)
        {
            if(Btncheckout.Text !="")
            {
                if(MessageBox.Show("Are you Sure?","Confirmation",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
                {
                    String cdate = txtcheckout.Text;
                    query = "Update Reservation set Scheckout = 'YES' ,checkoutdate = '"+ txtcheckout + "' where id = "+id+" Update AddingRooms set Booked = 'NO' where RoomNo = '"+txtroomnumber.Text+"'";
                    db.setData(query,"Checkout Sucessfully.");
                    Billingcs_Load(this, null);
                    clearAll();
                }
            }
            else
            {
                MessageBox.Show("Please Select Customer", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void clearAll()
        {
            textboxname.Clear();
            txtroomnumber.Clear();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtroomnumber.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
        }
    }
}
