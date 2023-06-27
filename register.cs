using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FleetSystem
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
           }

        private void txtNOK_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string connectionString;

            SqlConnection sqlCon;

            connectionString = @"Data Source=ZA-NB-PF1DT4X0\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True";

            sqlCon = new SqlConnection(connectionString);

            sqlCon.Open();

            SqlCommand command = new SqlCommand("Insert into registration values( @userID,@firstName, @surname, @email, @cellphoneNum, @nextofKin, @nextofKinNumber, @pass, @DOB, @IDNumber, @LicenseNum, @pasword, @myCellNumber, @Address)", sqlCon);

            command.Parameters.AddWithValue("@userID",int.Parse (txtUserID.Text));
            command.Parameters.AddWithValue("@firstName", txtName.Text);
            command.Parameters.AddWithValue("@surname", txtSurname.Text);
            command.Parameters.AddWithValue("@email", txtEmail.Text);
            command.Parameters.AddWithValue("@cellphoneNum", txtCellNum.Text);
            command.Parameters.AddWithValue("@nextofKin", txtNOK.Text);
            command.Parameters.AddWithValue("@nextofKinNumber", txtNOKNr.Text);
            command.Parameters.AddWithValue("@pass", txtPassword.Text);
            command.Parameters.AddWithValue("@DOB", txtDOB.Text);
            command.Parameters.AddWithValue("@IDNumber", txtIDNumber.Text);
            command.Parameters.AddWithValue("@LicenseNum", txtLicenseNum.Text);
            command.Parameters.AddWithValue("@pasword", txtVerPassword.Text);
            command.Parameters.AddWithValue("@myCellNumber", txtCellNum.Text);
            command.Parameters.AddWithValue("Address", txtAddress.Text);
            command.ExecuteNonQuery();
            sqlCon.Close();
            MessageBox.Show("registered successfully");
            Form1 login = new Form1();
            login.Show();
            this.Hide();

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
        
        }
    }
}
