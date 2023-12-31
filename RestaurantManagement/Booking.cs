﻿using Microsoft.Win32.SafeHandles;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.VisualBasic;

namespace RestaurantManagement
{
    public partial class Booking : Form
    {
        public Booking()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ntkha\OneDrive\Tài liệu\RestaurantDb.mdf"";Integrated Security=True;Connect Timeout=30");

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        decimal setcost = 0m, bevcost = 0m, grandtotal = 0.0m, balance = 0.0m;
        string sets = "", beverages = "";
        int custID;

        private void resetTextBox(System.Windows.Forms.TextBox Price, System.Windows.Forms.TextBox quantity, decimal price)
        {
            Price.Enabled = false;
            quantity.Enabled = false;
            Price.Text = price.ToString();
            quantity.Text = "";
        }
        private void Beverage1_CheckedChanged(object sender, EventArgs e)
        {
            if (Beverage1.Checked == true)
            {
                champPrice.Enabled = true;
                champQuantity.Enabled = true;
            }
            else
            {
                resetTextBox(champPrice, champQuantity, 75.5m);
            }

        }

        private void Beverage2_CheckedChanged(object sender, EventArgs e)
        {

            if (Beverage2.Checked == true)
            {
                finePrice.Enabled = true;
                fineQuantity.Enabled = true;
            }
            else
            {
                resetTextBox(finePrice, fineQuantity, 85.75m);
            }
        }

        private void Beverage3_CheckedChanged(object sender, EventArgs e)
        {
            if (Beverage3.Checked == true)
            {
                cocktailPrice.Enabled = true;
                cocktailQuantity.Enabled = true;
            }
            else
            {
                resetTextBox(cocktailPrice, cocktailQuantity, 10.25m);
            }
        }

        private void Beverage4_CheckedChanged(object sender, EventArgs e)
        {
            if (Beverage4.Checked == true)
            {
                whiskiesPrice.Enabled = true;
                whiskiesQuantity.Enabled = true;
            }
            else
            {
                resetTextBox(whiskiesPrice, whiskiesQuantity, 45.25m);
            }
        }

        private void Beverage5_CheckedChanged(object sender, EventArgs e)
        {
            if (Beverage5.Checked == true)
            {
                spiritPrice.Enabled = true;
                spiritQuantity.Enabled = true;
            }
            else
            {
                resetTextBox(spiritPrice, spiritQuantity, 30.25m);
            }
        }

        private void Beverage6_CheckedChanged(object sender, EventArgs e)
        {
            if (Beverage6.Checked == true)
            {
                nonPrice.Enabled = true;
                nonQuantity.Enabled = true;
            }
            else
            {
                resetTextBox(nonPrice, nonQuantity, 8.5m);
            }
        }

        private void Set1_CheckedChanged(object sender, EventArgs e)
        {
            if (Set1.Checked == true)
            {
                huePrice.Enabled = true;
                hueQuantity.Enabled = true;
            }
            else
            {
                resetTextBox(huePrice, hueQuantity, 65m);
            }
        }

        private void Set2_CheckedChanged(object sender, EventArgs e)
        {
            if (Set2.Checked == true)
            {
                saigonPrice.Enabled = true;
                saigonQuantity.Enabled = true;
            }
            else
            {
                resetTextBox(saigonPrice, saigonQuantity, 52m);
            }
        }

        private void Set3_CheckedChanged(object sender, EventArgs e)
        {
            if (Set3.Checked == true)
            {
                hoiPrice.Enabled = true;
                hoiQuantity.Enabled = true;
            }
            else
            {
                resetTextBox(hoiPrice, hoiQuantity, 50m);
            }
        }

        private void Set5_CheckedChanged(object sender, EventArgs e)
        {
            if (Set5.Checked == true)
            {
                hanoiPrice.Enabled = true;
                hanoiQuantity.Enabled = true;
            }
            else
            {
                resetTextBox(hanoiPrice, hanoiQuantity, 49m);
            }
        }

        private void Set4_CheckedChanged(object sender, EventArgs e)
        {
            if (Set4.Checked == true)
            {
                lotusPrice.Enabled = true;
                lotusQuantity.Enabled = true;
            }
            else
            {
                resetTextBox(lotusPrice, lotusQuantity, 45m);
            }
        }

        private void Set6_CheckedChanged(object sender, EventArgs e)
        {
            if (Set6.Checked == true)
            {
                danangPrice.Enabled = true;
                danangQuantity.Enabled = true;
            }
            else
            {
                resetTextBox(danangPrice, danangQuantity, 50.5m);
            }
        }

        private void beverageBtn_Click(object sender, EventArgs e)
        {
            decimal bev1 = 0.0m, bev2 = 0.0m, bev3 = 0.0m, bev4 = 0.0m, bev5 = 0.0m, bev6 = 0.0m;

            //champagne
            if (Beverage1.Checked == true)
            {
                if (champQuantity.Text == "")
                {
                    MessageBox.Show("Enter the quanity");
                }
                else
                {
                    bev1 = Convert.ToDecimal(champPrice.Text) * Convert.ToInt32(champQuantity.Text);
                    beverages += "Champagne ";
                }
            }


            //fine wine
            if (Beverage2.Checked == true)
            {
                if (fineQuantity.Text == "")
                {
                    MessageBox.Show("Enter the quanity");
                }
                else
                {
                    bev2 = Convert.ToDecimal(finePrice.Text) * Convert.ToInt32(fineQuantity.Text);
                    beverages += "Fine Wines ";
                }
            }

            //cocktail
            if (Beverage3.Checked == true)
            {
                if (cocktailQuantity.Text == "")
                {
                    MessageBox.Show("Enter the quanity");
                }
                else
                {
                    bev3 = Convert.ToDecimal(cocktailPrice.Text) * Convert.ToInt32(cocktailQuantity.Text);
                    beverages += "Cocktail ";
                }
            }

            //whiskies
            if (Beverage4.Checked == true)
            {
                if (whiskiesQuantity.Text == "")
                {
                    MessageBox.Show("Enter the quanity");
                }

                else
                {
                    bev4 = Convert.ToDecimal(whiskiesPrice.Text) * Convert.ToInt32(whiskiesQuantity.Text);
                    beverages += "Whiskies ";
                }
            }

            //spirit
            if (Beverage5.Checked == true)
            {
                if (spiritQuantity.Text == "")
                {
                    MessageBox.Show("Enter the quanity");
                }
                else
                {
                    bev5 = Convert.ToDecimal(spiritPrice.Text) * Convert.ToInt32(spiritQuantity.Text);
                    beverages += "Spirits ";
                }
            }


            //non-alcohol
            if (Beverage6.Checked == true)
            {
                if (nonQuantity.Text == "")
                {
                    MessageBox.Show("Enter the quanity");
                }
                else
                {
                    bev6 = Convert.ToDecimal(nonPrice.Text) * Convert.ToInt32(nonQuantity.Text);
                    beverages += "Non-Alcohol ";
                }
            }


            bevcost = bev1 + bev2 + bev3 + bev4 + bev5 + bev6;
            grandtotal = bevcost + setcost + Convert.ToDecimal(serviceFee.Text);
            grandTotal.Text = grandtotal.ToString();
            bevCost.Text = "TOTAL: $" + bevcost.ToString();

        }

        private void setBtn_Click(object sender, EventArgs e)
        {
            decimal set1 = 0.0m, set2 = 0.0m, set3 = 0.0m, set4 = 0.0m, set5 = 0.0m, set6 = 0.0m;

            //hue
            if (Set1.Checked == true)
            {
                if (hueQuantity.Text == "")
                {
                    MessageBox.Show("Enter the quanity");
                }
                else
                {
                    set1 = Convert.ToDecimal(huePrice.Text) * Convert.ToInt32(hueQuantity.Text);
                    sets += "Hue " + hueQuantity + ";";
                }
            }


            //saigon
            if (Set2.Checked == true)
            {
                if (saigonQuantity.Text == "")
                {
                    MessageBox.Show("Enter the quanity");
                }
                else
                {
                    set2 = Convert.ToDecimal(saigonPrice.Text) * Convert.ToInt32(saigonQuantity.Text);
                    sets += "SaiGon " + saigonQuantity + ";";
                }
            }

            //hoian
            if (Set3.Checked == true)
            {
                if (hoiQuantity.Text == "")
                {
                    MessageBox.Show("Enter the quanity");
                }
                else
                {
                    set3 = Convert.ToDecimal(hoiPrice.Text) * Convert.ToInt32(hoiQuantity.Text);
                    sets += "HoiAn " + hoiQuantity + ";";
                }
            }

            //lotus
            if (Set4.Checked == true)
            {
                if (lotusQuantity.Text == "")
                {
                    MessageBox.Show("Enter the quanity");
                }

                else
                {
                    set4 = Convert.ToDecimal(lotusPrice.Text) * Convert.ToInt32(lotusQuantity.Text);
                    sets += "Lotus " + lotusQuantity + ";";
                }
            }

            //hanoi
            if (Set5.Checked == true)
            {
                if (hanoiQuantity.Text == "")
                {
                    MessageBox.Show("Enter the quanity");
                }
                else
                {
                    set5 = Convert.ToDecimal(hanoiPrice.Text) * Convert.ToInt32(hanoiQuantity.Text);
                    sets += "HaNoi " + hanoiQuantity + ";";
                }
            }


            //danang
            if (Set6.Checked == true)
            {
                if (danangQuantity.Text == "")
                {
                    MessageBox.Show("Enter the quanity");
                }
                else
                {
                    set6 = Convert.ToDecimal(danangPrice.Text) * Convert.ToInt32(danangQuantity.Text);
                    sets += "DaNang " + danangQuantity + ";";
                }
            }


            setcost = set1 + set2 + set3 + set4 + set5 + set6;
            if (serviceFee.Text != "")
            {
                grandtotal = bevcost + setcost + Convert.ToDecimal(serviceFee.Text);
            }
            else
            {
                grandtotal = bevcost + setcost;
            }
            grandTotal.Text = grandtotal.ToString();
            setCost.Text = "TOTAL: $" + setcost.ToString();
        }

        private void getCustID()
        {

            Con.Open();
            SqlCommand cmd = new SqlCommand("select CustID from CustomerTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CustID", typeof(string));
            dt.Load(rdr);
            custIDCb.ValueMember = "CustID";
            custIDCb.DataSource = dt;
            Con.Close();


        }

        private void Booking_Load(object sender, EventArgs e)
        {
            getCustID();
        }

        private void fetchCustName()
        {

            Con.Open();
            //set to selectedValue to return  DataRowView
            string query = "select * from CustomerTbl where CustID= " + custIDCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //Error: due to loading second combobox while filling data in first combo
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                custName.Text = "" + dr["CustName"].ToString();
            }
            Con.Close();

        }

        private void custIDCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchCustName();

        }

        private void serviceFee_TextChanged(object sender, EventArgs e)
        {
            if (serviceFee.Text != "")
            {
                grandtotal = bevcost + setcost + Convert.ToDecimal(serviceFee.Text);

            }
            grandTotal.Text = grandtotal.ToString();
            if (deposit.Text != "")
            {
                BalanceTb.Text = grandtotal.ToString();
            }
            else
            {
                balance = grandtotal - Convert.ToDecimal(deposit.Text);
            }
        }

        private void deposit_TextChanged(object sender, EventArgs e)
        {
            if (deposit.Text != "")
            {
                balance = grandtotal - Convert.ToDecimal(deposit.Text);
            }
            BalanceTb.Text = balance.ToString();
        }

        private void BookingBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            sets = "";
            beverages = "";
            setcost = 0m;
            bevcost = 0m;
            grandtotal = 0.0m;
            balance = 0.0m;
            grandTotal.Text = "0.0";
            serviceFee.Text = "0.0";
            deposit.Text = "0.0";
            BalanceTb.Text = "0.0";
            bevCost.Text = "TOTAL: $0";
            setCost.Text = "TOTAL: $0";
        }
    }
}
