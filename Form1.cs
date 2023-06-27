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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
            string password = txtPassword.Text;
            string username = txtUsername.Text;
            
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string name = txtUsername.Text;
            string password = txtPassword.Text;
            if (name == "")
            {
                MessageBox.Show("Please enter a valid name");
                txtUsername.Clear();
            }
            if(password == "")
            {
                MessageBox.Show("Enter a valid password");
            }

            else
            {
                DriverDetails driverDetails= new DriverDetails();
                //this.Close();
                driverDetails.Show();
               
            }
            }
            

        private void btnRegister_Click(object sender, EventArgs e)
        {
            register reg = new register();
            reg.Show();
            this.Hide();

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
        
            }
        
    }
}
