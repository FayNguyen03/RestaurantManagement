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
            if (BookingDGV.SelectedRows[0].Cells[0].Value.ToString() == "")
            {
                bookingKey = 0;
            }
            else
            {
                bookingKey = Convert.ToInt32(BookingDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Main mainForm = new Main();

            mainForm.Show();

            this.Hide();
        }

        private void populate()
        {
            Con.Open();
            string query = "select bookingID, custID, BookingDate, BookingTime, Persons, ServiceFee, GrandTotal, Balance from BookingTbl WHERE Serve = 0";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BookingDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (bookingKey == 0)
            {
                MessageBox.Show("Select The Booking To Be Deleted");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "Delete from BookingTbl where bookingID=" + bookingKey + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Booking Deleted Successfully");
                    Con.Close();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Booking bookingForm = new Booking();
            bookingForm.Show();
            this.Hide();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "Delete from BookingTbl; DBCC CHECKIDENT ('BookingTbl', RESEED, 100);";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("All bookings deleted");
                Con.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
