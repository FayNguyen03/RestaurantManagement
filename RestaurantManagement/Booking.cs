using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagement
{
    public partial class Booking : Form
    {
        public Booking()
        {
            InitializeComponent();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Beverage1_CheckedChanged(object sender, EventArgs e)
        {
            champPrice.Enabled = true;
            champQuantity.Enabled = true;
        }
    }
}
