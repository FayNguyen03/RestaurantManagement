using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;
using Microsoft.Data.SqlClient;

namespace RestaurantManagement
{
    public partial class ViewBooking : Form
    {
        //public datagridview 
        public DataGridView BookingDVGPublic => BookingDGV;

        public ViewBooking()
        {
            InitializeComponent();
            
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ntkha\OneDrive\Tài liệu\RestaurantDb.mdf"";Integrated Security=True;Connect Timeout=30");

        private void ViewBooking_Load(object sender, EventArgs e)
        {
            populate();
        }

        int bookingKey = 0;
        private void BookingDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (BookingDGV.SelectedRows..Text == "")
            {
                custkey = 0;
            }
            else
            {
                custkey = Convert.ToInt32(CustomerDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void populate()
        {
            Con.Open();
            string query = "select bookingID, custID, BookingDate, BookingTime, Persons, ServiceFee, GrandTotal, Balance from BookingTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BookingDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

    }
}
