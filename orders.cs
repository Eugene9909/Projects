using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FleetSystem
{
    public partial class orders : Form
    {
        public orders()
        {
            InitializeComponent();
        }

        private void orders_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to the orders portal.");
            MessageBox.Show("Please capture the order details ");
        }

        private void txtOrderID_TextChanged(object sender, EventArgs e)
        {
            if(txtOrderID.Text == "")
            {
                MessageBox.Show("Please enter a valid order ID");
            }
        }

        private void txtOrderName_TextChanged(object sender, EventArgs e)
        {
            if(txtOrderName.Text == "")
            {
                MessageBox.Show("Please enter a valid product name");

            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if(txtQuantity.Text == "")
            {
                MessageBox.Show("Please enter valid quantity");

            }
        }

        private void txtMass_TextChanged(object sender, EventArgs e)
        {
            if(txtMass.Text == "")
            {
                MessageBox.Show("Please enter valid mass size");
            }
        }
    }
}
