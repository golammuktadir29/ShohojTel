using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ShohojTel

{

    public partial class TicketCounterUserControl : UserControl
    {
        public TicketCounterUserControl()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }



        private void TicketBtn_Click(object sender, EventArgs e)
        {
            string names = NameTextBox.Text;
            string email = EmailTextBox.Text;
            string phone = PhoneTextBox.Text;
            string nid = NIDTextBox.Text;
            DateTime dates = DateTimePicker.Value;
            string fuel = FuelTypeComboBox.SelectedItem.ToString();
            string vehicle = VehicleTypeComboBox.SelectedItem.ToString();
            string dbString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=registerUser;Integrated Security=True;Trust Server Certificate=True";
            string query = @$"insert into ticket(names,email,phone,nid,dates,fuel,vehicle)
                            values('{names}','{email}','{phone}','{nid}','{dates}','{fuel}','{vehicle}')";


            NameTextBox.Text = "";
            EmailTextBox.Text = "";
            NIDTextBox.Text = "";
            PhoneTextBox.Text = "";
            FuelTypeComboBox.SelectedIndex = 0;
            VehicleTypeComboBox.SelectedIndex = 0;

            if (names == "" || email == "" || phone == "" || nid == "")
            {
                MessageBox.Show("Fill all the fields !");
            }
            else
            {
                SqlConnection con1 = new SqlConnection(dbString);
                con1.Open();
                SqlCommand cmd1 = new SqlCommand(query, con1);
                int result = (int)cmd1.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Ticket created !");
                }
                else
                {
                    MessageBox.Show("Error Sigh!!!!");
                }
                con1.Close();
            }







        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            VehicleTypeComboBox.Items.AddRange(new string[]
            {
                "Select One",
                "Car",
                "Bike",
                "Pickup",
                "Truck"
            });

            VehicleTypeComboBox.SelectedIndex = 0;

         
            FuelTypeComboBox.Items.Add("Select One");
            FuelTypeComboBox.SelectedIndex = 0;
        }

        private void VehicleTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FuelTypeComboBox.Items.Clear();

           
            FuelTypeComboBox.Items.Add("Select One");

            if (VehicleTypeComboBox.Text == "Car")
            {
                FuelTypeComboBox.Items.AddRange(new string[]
                {
                    "Petrol",
                    "Diesel",
                    "Electric"
                });
            }
            else if (VehicleTypeComboBox.Text == "Bike")
            {
                FuelTypeComboBox.Items.AddRange(new string[]
                {
                    "Petrol",
                    "Electric"
                });
            }
            else if (VehicleTypeComboBox.Text == "Pickup")
            {
                FuelTypeComboBox.Items.AddRange(new string[]
                {
                    "Diesel",
                    "Petrol"
                });
            }
            else if (VehicleTypeComboBox.Text == "Truck")
            {
                FuelTypeComboBox.Items.AddRange(new string[]
                {
                    "Diesel",
                    "CNG"
                });
            }

            
            FuelTypeComboBox.SelectedIndex = 0;
        }

        private void FuelTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FuelTypeComboBox.SelectedIndex > 0)
            {
                MessageBox.Show("Selected Fuel: " + FuelTypeComboBox.Text);
            }
        }
    }
}
