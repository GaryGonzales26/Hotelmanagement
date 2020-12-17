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
    public partial class AddRoom : Form
    {
        Database db = new Database();
        String query;

        public AddRoom()
        {
            InitializeComponent();
        }
        public int addprice ;
        private void AddRoom_Load(object sender, EventArgs e)
        {
            query = "SELECT * FROM AddingRooms";
            DataSet ds = db.getData(query);
            DataGridView1.DataSource = ds.Tables[0];
        }

        private void btnAddrom_Click(object sender, EventArgs e)
        {
            if(txtroomnumber.Text != "" && txtroomtype.Text != "" && txtroombeds.Text != "" && txtroomprice.Text != "" )
            {
                query = "INSERT INTO AddingRooms(RoomNo,RoomType,Beds,Price) VALUES ('"+ txtroomnumber.Text + "','" + txtroomtype.Text + "','" + txtroombeds.Text + "','" + txtroomprice.Text + "') ";
                db.setData(query, "Room Successfuly Added");

                AddRoom_Load(this, null);

            }
            else
            {
                MessageBox.Show("Fill up all the fields.", "WARNING!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            txtroomnumber.Clear();
            txtroomprice.Clear();
            txtroomtype.SelectedIndex = -1;
            txtroombeds.SelectedIndex = -1;
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtroomnumber_TextChanged(object sender, EventArgs e)
        {

        }

        public void txtroombeds_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtroombeds.SelectedItem.Equals("1 BED"))
            {

                addprice = 100;

                txtroomprice.Text = addprice.ToString();

            }
            else if (txtroombeds.SelectedItem.Equals("2 BEDS"))
            {
                addprice = 200;

                txtroomprice.Text = addprice.ToString();

            }
            else if (txtroombeds.SelectedItem.Equals("3 BEDS"))
            {
                addprice = 300;

                txtroomprice.Text = addprice.ToString();

            }
        }

        private void txtroomprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtroomhours_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
