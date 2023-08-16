using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace RestaurantManagement
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ntkha\OneDrive\Tài liệu\RestaurantDb.mdf"";Integrated Security=True;Connect Timeout=30");
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (CustName.Text == "" || CustPhone.Text == "" || CustAdd.Text == "")
            {
                MessageBox.Show("Missing Data!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into CustomerTbl values('" + CustName.Text + "','" + CustAdd.Text + "','" + CustPhone.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Succesfully Added");
                    Con.Close();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void populate()
        {
            Con.Open();
            string query = "select * from CustomerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CustomerDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void CustomerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CustName.Text = CustomerDGV.SelectedRows[0].Cells[1].Value.ToString();
            CustAdd.Text = CustomerDGV.SelectedRows[0].Cells[2].Value.ToString();
            CustPhone.Text = CustomerDGV.SelectedRows[0].Cells[3].Value.ToString();
        }
    }
}
