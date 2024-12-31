using Microsoft.Win32.SafeHandles;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using TextBox = System.Windows.Forms.TextBox;


namespace RestaurantManagement
{



    public partial class Booking : Form
    {

        private ViewBooking viewBooking1;
        // Arrays for CheckBox controls, price TextBoxes, quantity TextBoxes, and default prices
        private CheckBox[] beverageCheckBoxes;
        private TextBox[] quantitySet;
        private TextBox[] quantityBeverage;
        public Booking(ViewBooking v1)
        {
            InitializeComponent();
            viewBooking1 = v1;
            beverageCheckBoxes = new CheckBox[] { Beverage1, Beverage2, Beverage3, Beverage4, Beverage5, Beverage6 };
            quantityBeverage = new TextBox[] { champQuantity, fineQuantity, cocktailQuantity, whiskiesQuantity, spiritQuantity, nonQuantity };
            quantitySet = new TextBox[] { hueQuantity, saigonQuantity, hoiQuantity, lotusQuantity, hanoiQuantity, danangQuantity };
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ntkha\OneDrive\Tài liệu\RestaurantDb.mdf"";Integrated Security=True;Connect Timeout=30");

        //Exit Button
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Total
        decimal setcost = 0m, bevcost = 0m, grandtotal = 0.0m, balance = 0.0m;

        string sets = "", beverages = "";
        //customer ID
        int custID;

        //reset the textbox
        private void resetTextBox(System.Windows.Forms.TextBox Price, System.Windows.Forms.TextBox quantity, decimal price)
        {
            Price.Enabled = false;
            quantity.Text = "0";
            quantity.Enabled = false;
            Price.Text = price.ToString();
            BalanceTb.Text = balance.ToString();
            grandTotal.Text = grandtotal.ToString();
           
        }


        private void Beverage1_CheckedChanged(object sender, EventArgs e)
        {
            if (beverageCheckBoxes[0].Checked == true)
            {
                champPrice.Enabled = true;
                quantityBeverage[0].Enabled = true;
            }
            else
            {
                resetTextBox(champPrice, quantityBeverage[0], 75.5m);
            }

        }

        private void Beverage2_CheckedChanged(object sender, EventArgs e)
        {

            if (beverageCheckBoxes[1].Checked == true)
            {
                finePrice.Enabled = true;
                quantityBeverage[1].Enabled = true;
            }
            else
            {
                resetTextBox(finePrice, quantityBeverage[1], 85.75m);
            }
        }

        private void Beverage3_CheckedChanged(object sender, EventArgs e)
        {
            if (beverageCheckBoxes[2].Checked == true)
            {
                cocktailPrice.Enabled = true;
                quantityBeverage[2].Enabled = true;
            }
            else
            {
                resetTextBox(cocktailPrice, quantityBeverage[2], 10.25m);
            }
        }

        private void Beverage4_CheckedChanged(object sender, EventArgs e)
        {
            if (beverageCheckBoxes[3].Checked == true)
            {
                whiskiesPrice.Enabled = true;
                quantityBeverage[3].Enabled = true;
            }
            else
            {
                resetTextBox(whiskiesPrice, quantityBeverage[3], 45.25m);
            }
        }

        private void Beverage5_CheckedChanged(object sender, EventArgs e)
        {
            if (beverageCheckBoxes[4].Checked == true)
            {
                spiritPrice.Enabled = true;
                quantityBeverage[4].Enabled = true;
            }
            else
            {
                resetTextBox(spiritPrice, quantityBeverage[4], 30.25m);
            }
        }

        private void Beverage6_CheckedChanged(object sender, EventArgs e)
        {
            if (beverageCheckBoxes[5].Checked == true)
            {
                nonPrice.Enabled = true;
                nonQuantity.Enabled = true;
            }
            else
            {
                resetTextBox(nonPrice, quantityBeverage[5], 8.5m);
            }
        }

        private void Set1_CheckedChanged(object sender, EventArgs e)
        {
            if (Set1.Checked == true)
            {
                huePrice.Enabled = true;
                quantitySet[0].Enabled = true;
            }
            else
            {
                resetTextBox(huePrice, quantitySet[0], 65m);
            }
        }

        private void Set2_CheckedChanged(object sender, EventArgs e)
        {
            if (Set2.Checked == true)
            {
                saigonPrice.Enabled = true;
                quantitySet[1].Enabled = true;
            }
            else
            {
                resetTextBox(saigonPrice, quantitySet[1], 52m);
            }
        }

        private void Set3_CheckedChanged(object sender, EventArgs e)
        {
            if (Set3.Checked == true)
            {
                hoiPrice.Enabled = true;
                quantitySet[2].Enabled = true;
            }
            else
            {
                resetTextBox(hoiPrice, quantitySet[2], 50m);
            }
        }

        private void Set5_CheckedChanged(object sender, EventArgs e)
        {
            if (Set5.Checked == true)
            {
                hanoiPrice.Enabled = true;
                quantitySet[4].Enabled = true;
            }
            else
            {
                resetTextBox(hanoiPrice, quantitySet[4], 49m);
            }
        }

        private void Set4_CheckedChanged(object sender, EventArgs e)
        {
            if (Set4.Checked == true)
            {
                lotusPrice.Enabled = true;
                quantitySet[3].Enabled = true;
            }
            else
            {
                resetTextBox(lotusPrice, quantitySet[3], 45m);
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
                resetTextBox(danangPrice, quantitySet[5], 50.5m);
            }
        }

        private void beverageBtn_Click(object sender, EventArgs e)
        {
            decimal bev1 = 0.0m, bev2 = 0.0m, bev3 = 0.0m, bev4 = 0.0m, bev5 = 0.0m, bev6 = 0.0m;

            //champagne
            if (Beverage1.Checked == true)
            {
                if (champQuantity.Text == "0")
                {
                    MessageBox.Show("Enter the quantity for the champagne");
                }
                else
                {
                    bev1 = Convert.ToDecimal(champPrice.Text) * Convert.ToInt32(champQuantity.Text);
                    beverages += "Champagne " + champQuantity + ";";
                }
            }


            //fine wine
            if (Beverage2.Checked == true)
            {
                if (fineQuantity.Text == "0")
                {
                    MessageBox.Show("Enter the quantity for fine wine");
                }
                else
                {
                    bev2 = Convert.ToDecimal(finePrice.Text) * Convert.ToInt32(fineQuantity.Text);
                    beverages += "Fine Wines " + fineQuantity + ";";
                }
            }

            //cocktail
            if (Beverage3.Checked == true)
            {
                if (cocktailQuantity.Text == "0")
                {
                    MessageBox.Show("Enter the quantity for cocktail");
                }
                else
                {
                    bev3 = Convert.ToDecimal(cocktailPrice.Text) * Convert.ToInt32(cocktailQuantity.Text);
                    beverages += "Cocktail " + cocktailQuantity + ";";
                }
            }

            //whiskies
            if (Beverage4.Checked == true)
            {
                if (whiskiesQuantity.Text == "0")
                {
                    MessageBox.Show("Enter the quantity for whisky");
                }

                else
                {
                    bev4 = Convert.ToDecimal(whiskiesPrice.Text) * Convert.ToInt32(whiskiesQuantity.Text);
                    beverages += "Whiskies " + whiskiesQuantity + ";";
                }
            }

            //spirit
            if (Beverage5.Checked == true)
            {
                if (spiritQuantity.Text == "0")
                {
                    MessageBox.Show("Enter the quantity for spirit");
                }
                else
                {
                    bev5 = Convert.ToDecimal(spiritPrice.Text) * Convert.ToInt32(spiritQuantity.Text);
                    beverages += "Spirits " + spiritQuantity + ";";
                }
            }


            //non-alcohol
            if (Beverage6.Checked == true)
            {
                if (nonQuantity.Text == "0")
                {
                    MessageBox.Show("Enter the quantity for non-alcohol");
                }
                else
                {
                    bev6 = Convert.ToDecimal(nonPrice.Text) * Convert.ToInt32(nonQuantity.Text);
                    beverages += "Non-Alcohol " + nonQuantity + ";";
                }
            }


            bevcost = bev1 + bev2 + bev3 + bev4 + bev5 + bev6;
            grandtotal = bevcost + setcost + Convert.ToDecimal(serviceFee.Text);
            grandTotal.Text = grandtotal.ToString();
            balance = grandtotal - Convert.ToDecimal(deposit.Text);
            BalanceTb.Text = balance.ToString();
            bevCost.Text = "TOTAL: $" + bevcost.ToString();

        }

        private void setBtn_Click(object sender, EventArgs e)
        {
            decimal set1 = 0.0m, set2 = 0.0m, set3 = 0.0m, set4 = 0.0m, set5 = 0.0m, set6 = 0.0m;

            //hue
            if (Set1.Checked == true)
            {
                if (hueQuantity.Text == "0")
                {
                    MessageBox.Show("Enter the quantity for Hue Set");
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
                if (saigonQuantity.Text == "0")
                {
                    MessageBox.Show("Enter the quantity for Sai Gon Set");
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
                if (hoiQuantity.Text == "0")
                {
                    MessageBox.Show("Enter the quantity for Hoi An Set");
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
                if (lotusQuantity.Text == "0")
                {
                    MessageBox.Show("Enter the quantity for Lotus Set");
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
                if (hanoiQuantity.Text == "0")
                {
                    MessageBox.Show("Enter the quantity for Ha Noi Set");
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
                if (danangQuantity.Text == "0")
                {
                    MessageBox.Show("Enter the quantity for Da Nang Sets");
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

            try
            {
                decimal depositAmount;
                if (!decimal.TryParse(deposit.Text, out depositAmount))
                {
                    MessageBox.Show("Please enter a valid numeric value for the deposit.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Exit the method to avoid further calculations
                }

                decimal balance = grandtotal - depositAmount;
                // Proceed with further logic, e.g., updating UI or saving the balance
            }
            catch (Exception ex)
            {
                // Handle unexpected errors gracefully
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            BalanceTb.Text = balance.ToString();
            setCost.Text = "TOTAL: $" + setcost.ToString();
        }

        //get the customerID from the database
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

        private void Booking_Load(object sender, EventArgs e)
        {
            getCustID();
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

        private void clear()
        {
            custIDCb.ResetText();
            CustDate.Value = DateAndTime.Today.Value;
            CustPeople.Text = "";
            timeCb.ResetText();
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
            if (grandTotal.Text == "0" || CustPeople.Text == null || custIDCb.SelectedValue == null)
            {
                MessageBox.Show("Missing Data!");
            }
            else
            {
                try
                {
                    Con.Open();
                    var custID = custIDCb.SelectedValue?.ToString();
                    var custDate = CustDate?.Value.ToString("yyyy-MM-dd") ?? DateAndTime.Today.ToString("yyyy-MM-dd");
                    var custTime = timeCb?.SelectedText.ToString() == null ? "N" : timeCb.SelectedItem.ToString();
                    var custPeople = string.IsNullOrEmpty(CustPeople.Text) ? "1" : CustPeople.Text;
                    string query = "INSERT INTO bookingTbl (custID, BookingDate, BookingTime, Persons, Hue, Saigon, HoiAn, Lotus, HaNoi, DaNang, Champagne, FineWine, Cocktail, Whiskies, Gin, NonAlcohol, CostDrinks, CostSets, ServiceFee, GrandTotal, Advance, Balance) VALUES ('" + custID + "','" + custDate + "','" + custTime + "','" +  custPeople + "','";
                    foreach (var set in quantitySet){
                        query += set.Text + "','";
                    }
                    foreach (var bev in quantityBeverage){
                        query += bev.Text + "','";
                    }
                    query += bevcost.ToString() + "','" + setcost.ToString() + "','" + serviceFee.Text + "','" + grandtotal.ToString() + "','" + deposit.Text + "','" + balance.ToString() + "')";
                    MessageBox.Show(query);
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Booking Successfully Added");
                    Con.Close();
                    populate();
                    clear();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Con.Close();
                }
            }
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

            //Reset everything
            if (Beverage1.Checked == true)
            {
                resetTextBox(champPrice, champQuantity, 75.5m);
                Beverage1.Checked = false;
            }

            if (Beverage2.Checked == true)
            {
                resetTextBox(finePrice, fineQuantity, 85.75m);
                Beverage2.Checked = false;
            }

            if (Beverage3.Checked == true)
            {
                resetTextBox(cocktailPrice, cocktailQuantity, 10.25m);
                Beverage3.Checked = false;
            }

            if (Beverage4.Checked == true)
            {
                resetTextBox(whiskiesPrice, whiskiesQuantity, 45.25m);
                Beverage4.Checked = false;
            }

            if (Beverage5.Checked == true)
            {
                resetTextBox(spiritPrice, spiritQuantity, 30.25m);
                Beverage5.Checked = false;
            }

            if (Beverage6.Checked == true)
            {
                resetTextBox(nonPrice, nonQuantity, 8.5m);
                Beverage6.Checked = false;
            }

            if (Set1.Checked == true)
            {
                resetTextBox(huePrice, hueQuantity, 65m);
                Set1.Checked = false;
            }

            if (Set2.Checked == true)
            {
                resetTextBox(saigonPrice, saigonQuantity, 52m);
                Set2.Checked = false;
            }

            if (Set3.Checked == true)
            {
                resetTextBox(hoiPrice, hoiQuantity, 50m);
                Set3.Checked = false;
            }

            if (Set4.Checked == true)
            {
                resetTextBox(lotusPrice, lotusQuantity, 45m);
                Set4.Checked = false;
            }

            if (Set5.Checked == true)
            {
                resetTextBox(hanoiPrice, hanoiQuantity, 49m);
                Set5.Checked = false;
            }

            if (Set6.Checked == true)
            {
                resetTextBox(danangPrice, danangQuantity, 50.5m);
                Set6.Checked = false;
            }
        }
        private void populate()
        {
            Con.Open();
            string query = "select * from BookingTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            viewBooking1.BookingDVGPublic.DataSource = ds.Tables[0];
            Con.Close();
        }

       
    }

}
