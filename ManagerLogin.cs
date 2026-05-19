using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ShohojTel
{
    public partial class ManagerLogin : Form
    {
        public ManagerLogin()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string name = EmailTextBox.Text;
            string password = PasswordTextBox.Text;
            if (name == "manager" || password == "1234")
            {
                MessageBox.Show("Logging you in as a manager !!");
                Manager managerx = new Manager();
                managerx.Visible = true;
                this.Visible = false;
            }
            else {
                MessageBox.Show("Manager credentials wrong!!");
            }
        }
    }
}
