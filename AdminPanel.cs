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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void ShowReportsBtn_Click(object sender, EventArgs e)
        {
            string dbString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=registerUser;Integrated Security=True;Trust Server Certificate=True";
            string checkReportsQuery= $"select * from reports";


            SqlConnection con = new SqlConnection(dbString);
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(checkReportsQuery, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);



            ReportsDataGridView.DataSource = null;
            ReportsDataGridView.Columns.Clear();
            ReportsDataGridView.AutoGenerateColumns = true;
            ReportsDataGridView.DataSource = dataTable;

            con.Close();
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            Login loginx = new Login();
            loginx.Visible = true;
            this.Visible = false;


        }
    }
}
