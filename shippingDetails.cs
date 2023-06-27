using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FleetSystem
{
    public partial class shippingDetails : Form
    {
        public shippingDetails()
        {
            InitializeComponent();
        
        }

        private void shippingDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventoryDataSet.orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.inventoryDataSet.orders);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ordersTableAdapter.FillBy(this.inventoryDataSet.orders);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
