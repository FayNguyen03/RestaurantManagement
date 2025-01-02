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
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ntkha\OneDrive\Tài liệu\RestaurantDb.mdf"";Integrated Security=True;Connect Timeout=30");


        int staffkey = 0;
        private void StaffDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            StaffName.Text = StaffDGV.SelectedRows[0].Cells[1].Value.ToString();
            StaffPhone.Text = StaffDGV.SelectedRows[0].Cells[2].Value.ToString();
            StaffGender.SelectedItem = StaffDGV.SelectedRows[0].Cells[3].Value.ToString();
            StaffPass.Text = StaffDGV.SelectedRows[0].Cells[4].Value.ToString();

            if (StaffName.Text == "")
            {
                staffkey = 0;
            }
            else
            {
                staffkey = Convert.ToInt32(StaffDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Main mainForm = new Main();

            mainForm.Show();

            this.Hide();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (StaffName.Text == "" || StaffPhone.Text == "" || StaffPass.Text == "" || StaffGender.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Data!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into StaffTbl values('" + StaffName.Text + "','" + StaffPhone.Text + "','" + StaffGender.SelectedItem.ToString() + "','" + StaffPass.Text + "')";
                    //Console.WriteLine(query);
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Staff Succesfully Added");
                    Con.Close();
                    populate();
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //retrieving dat from a database table named StaffTbl and populates it into a DataGridView control named StaffDGV
        private void populate()
        {
            Con.Open();
            string query = "select * from StaffTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            StaffDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void clear()
        {
            StaffName.Text = "";
            StaffPhone.Text = "";
            staffkey = 0;
            StaffPass.Text = "";
            StaffGender.SelectedIndex = -1;
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (staffkey == 0)
            {
                MessageBox.Show("Select The Staff To Be Deleted");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "Delete from StaffTbl where StaffID=" + staffkey + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Staff Deleted Successfully");
                    Con.Close();
                    populate();
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (StaffName.Text == "" || StaffPass.Text == "" || StaffPhone.Text == "" || StaffGender.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Data!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "Update StaffTbl set StaffName='" + StaffName.Text + "',StaffPhone='" + StaffPhone.Text + "',StaffGender='" + StaffGender.SelectedItem.ToString() + "',StaffPassword='" + StaffPass.Text + "' where StaffID=" + staffkey + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Staff Succesfully Updated");
                    Con.Close();
                    populate();
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
