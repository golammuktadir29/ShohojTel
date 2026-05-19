
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



namespace ShohojTel
{
    public partial class AdminLogin : Form

    {
        public AdminLogin()
        {
            InitializeComponent();
        }
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string name = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;
            if (name == "admin" && password == "1234")
            {
                MessageBox.Show("Logging you as an Admin!!");
                AdminPanel adminpanel = new AdminPanel();
                adminpanel.Visible = true;
                this.Visible = false;


            }
            else
            {
                MessageBox.Show("Admin credentials are wrong !! ");
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Login loginxy = new Login();
            loginxy.Visible = true;

            this.Visible= false;
        }
    }
}
