using Isopoh.Cryptography.Argon2;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ShohojTel
{
    public partial class DashBoardUserControl : UserControl
    {
        public DashBoardUserControl()
        {
            InitializeComponent();
        }

        

        private void UpdatePassBtn_Click(object sender, EventArgs e)
        {
            string email = EmailTxtBox.Text;
            string oldPassword = OldPassTxtBox.Text;
            string newPassword = NewPassTxtBox.Text;
            string confirmPassword = ConfirmPassTxtBox.Text;
            string hashedPasswordToStore = Argon2.Hash(newPassword);
            string dbString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=registerUser;Integrated Security=True;Trust Server Certificate=True";
            string checkQuery = $"select passwords from RegisterUser where email='{email}'";
            string updateQuery = $"UPDATE RegisterUser SET passwords ='{hashedPasswordToStore}' WHERE email='{email}'";

            if (email == "" || oldPassword == "" || newPassword == "" || confirmPassword == "")
            {
                MessageBox.Show("Make sure that every field is filled !!!");
            }
            else
            {
                if (oldPassword == newPassword)
                {
                    MessageBox.Show("New password and old password can not be same !!");
                    OldPassTxtBox.Clear();
                    NewPassTxtBox.Clear();
                }
                else if (newPassword != confirmPassword)
                {
                    MessageBox.Show("Make sure that passwords match(es) !!");
                    OldPassTxtBox.Clear();
                    NewPassTxtBox.Clear();
                    ConfirmPassTxtBox.Clear();


                }
                else
                {
                    SqlConnection con1 = new SqlConnection(dbString);
                    con1.Open();
                    SqlCommand cmd = new SqlCommand(checkQuery, con1);
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        string hash = result.ToString();
                        bool isValid = Argon2.Verify(hash, oldPassword);
                        if (isValid) {
                            SqlConnection con2 = new SqlConnection(dbString);
                            con2.Open();
                            SqlCommand cmd2 = new SqlCommand(updateQuery, con2);
                            int result2 =(int)cmd2.ExecuteNonQuery();
                            if (result2> 0) {
                                MessageBox.Show("Password updated!!");
                                OldPassTxtBox.Clear();
                                NewPassTxtBox.Clear();
                                ConfirmPassTxtBox.Clear();
                                EmailTxtBox.Clear();


                            }
                            else
                            {
                                MessageBox.Show("Server side error!!");
                            }
                            con2.Close();


                        }
                        else
                        {
                            MessageBox.Show("Old password is incorrect !!!");
                            OldPassTxtBox.Clear();
                            NewPassTxtBox.Clear();
                            ConfirmPassTxtBox.Clear();

                        }

                    }
                    else {
                        MessageBox.Show("Check your email  !!!");
                        OldPassTxtBox.Clear();
                        NewPassTxtBox.Clear();
                        ConfirmPassTxtBox.Clear();

                    }


                 con1.Close();
                }
            }
            
        }

        private void ClearFieldBtn_Click(object sender, EventArgs e)
        {
            EmailTxtBox.Clear();
            OldPassTxtBox.Clear();
            ConfirmPassTxtBox.Clear();
            NewPassTxtBox.Clear();

        }
    }
}
