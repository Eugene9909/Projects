using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FleetSystem
{
    public partial class DriverDetails : Form
    {
        public DriverDetails()
        {
            InitializeComponent();
        }

        private void DriverDetails_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=ZA-NB-PF1DT4X0\\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            string selectSql = "select* from registration";
            SqlCommand command = new SqlCommand(selectSql, connection);
           

            try
            {
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        txtName.Text = (reader["firstName"].ToString());
                        txtSurname.Text = (reader["surname"].ToString());
                        txtEmail.Text = (reader["email"].ToString());
                        txtIDNum.Text = (reader["IDNumber"].ToString());
                        txtCellNum.Text = (reader["myCellNumber"].ToString());
                        txtAddress.Text = (reader["Address"].ToString());

                    }


                }

            }

            finally
            {
                connection.Close();
            }
        }

        private void btnShipping_Click(object sender, EventArgs e)
        {
            shippingDetails shipping = new shippingDetails();
            shipping.Show();
            this.Close();
        }
    }
}