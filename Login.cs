using Isopoh.Cryptography.Argon2;
using Microsoft.Data.SqlClient;
using System.Collections;
using System.Drawing.Text;
using System.Security.Policy;

namespace ShohojTel


{

    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        private void LoginBtn(object sender, EventArgs e)
        {
            //MessageBox.Show("Button Clicked");


            string email = EmailTextBox.Text;
            string passwords = PasswordTextBox.Text;
            string loginQuery = $"SELECT passwords FROM RegisterUser WHERE email='{email}'";
            string userNameFindQuery = $"select username from RegisterUser where email='{email}'";





            //string LoginQuery = @$"SELECT COUNT(*)
            //                 FROM RegisterUser
            //                WHERE email = '{email}' AND passwords = '{passwords}';";
            string dbString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=registerUser;Integrated Security=True;Trust Server Certificate=True";

            if (email == "" || passwords == "")
            {
                MessageBox.Show("Fill every fields!!");
            }
            else
            {
                SqlConnection con1 = new SqlConnection(dbString);
                con1.Open();
                SqlCommand cmd1 = new SqlCommand(loginQuery, con1);
                //int count = (int)cmd.ExecuteScalar();




                object result = cmd1.ExecuteScalar();

                if (result != null)
                {
                    string hash = result.ToString();
                    bool isValid = Argon2.Verify(hash, passwords);

                    if (isValid)
                    {
                        SqlConnection con2 = new SqlConnection(dbString);
                        con2.Open();
                        SqlCommand cmd2 = new SqlCommand(userNameFindQuery, con2);
                        object userNameResult = cmd2.ExecuteScalar().ToString();

                        MessageBox.Show("Logging you in !!");

                        Customer customer = new Customer($"{userNameResult}");

                        customer.Show();

                        this.Hide();
                        con2.Close();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Password !!");
                        EmailTextBox.Clear();
                        PasswordTextBox.Clear();
                    }

                }
                else
                {
                    MessageBox.Show("Try again and make sure you are a registered user!");
                }





                con1.Close();


            }
        }



        private void SignupBtn(object sender, EventArgs e)
        {
            Register registerForm = new Register();
            registerForm.Show();
            this.Visible = false;

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void PumpManagerLoginBtn_Click(object sender, EventArgs e)
        {
            ManagerLogin managerlogin = new ManagerLogin();
            managerlogin.Show();
            this.Visible = false;
        }

        private void AdminLoginBtn_Click(object sender, EventArgs e)
        {
            AdminLogin adminlogin = new AdminLogin();
            adminlogin.Visible = true;
            this.Visible = false;
        }


        //private void SignupBtn(object sender, EventArgs e)
        //{
        //    using (Register registerForm = new Register())
        //    {
        //        this.Hide();
        //        registerForm.ShowDialog();
        //        this.Show();
        //    }
        //}
    }
}