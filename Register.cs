using Microsoft.Data.SqlClient;
using Microsoft.Data.SqlClient.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Isopoh.Cryptography.Argon2;


namespace ShohojTel
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            string name = FullNameTextBox.Text;
            string email = EmailTextBox.Text;
            string passwords = PasswordTextBox.Text; 
            //#########hash the pswrd########//


            string hashedPassword = Argon2.Hash(passwords);
            string confirmedPasswords = ConfirmPasswordTextBox.Text;
            string dbString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=registerUser;Integrated Security=True;Trust Server Certificate=True";
            string CheckQuey = $@"select count(*) from RegisterUser where email='{email}'";
            string Registerquery = @$"insert into RegisterUser(username, email,passwords) values('{name}','{email}','{hashedPassword}')";





            //check if any field is null.
            if (name == "" || email =="" || passwords == "" || confirmedPasswords == "")
            {
                MessageBox.Show("Fill up every field !!!!");
                //FullNameTextBox.Clear();
                FullNameTextBox.Text = "";
                EmailTextBox.Text = "";
                PasswordTextBox.Text = "";
                ConfirmPasswordTextBox.Text = "";
            }
            else
            {
                if(passwords != confirmedPasswords)
                {
                    MessageBox.Show("Make sure your password(s) matches !!!");
                    PasswordTextBox.Text = "";
                    ConfirmPasswordTextBox.Text = "";

                }
                else {
                    SqlConnection con1 = new SqlConnection(dbString); 
                    con1.Open();
                    SqlCommand cmd1 = new SqlCommand(CheckQuey,con1);
                    int count = (int)cmd1.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Use log in for registered user!"); 
                        EmailTextBox.Clear();
                        PasswordTextBox.Clear();
                    }
                    else
                    {
                        SqlConnection con2 = new SqlConnection(dbString);
                        con2.Open();
                        SqlCommand cmd2 = new SqlCommand(Registerquery, con2);
                        int rows = cmd2.ExecuteNonQuery();// sql dependent method(CRUD) 
                        if (rows > 0)
                        {
                            MessageBox.Show("User registered successfully!");
                            FullNameTextBox.Text = "";
                            EmailTextBox.Text = "";
                            PasswordTextBox.Text = "";
                            ConfirmPasswordTextBox.Text = "";

                        }
                        else
                        {
                            MessageBox.Show("Registration failed.Try Again!!");
                        }
                        con2.Close();
                    }

                    con1.Close();
                    
                   
                }
                
                

            }
           
        }

  

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Login LoginForm = new Login();
            LoginForm.Show();
            this.Visible = false;
        }
    }
}
