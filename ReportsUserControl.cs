using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ShohojTel
{
    public partial class ReportsUserControl : UserControl
    {
        public ReportsUserControl()
        {
            InitializeComponent();
        }

        private void ReportBtn_Click(object sender, EventArgs e)
        {
            if (ReportTextBox.Text.Length > 300)
            {
                MessageBox.Show("Write between 300 words!!");
            }
            else
            {
                string reportText = ReportTextBox.Text;
                string dbString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=registerUser;Integrated Security=True;Trust Server Certificate=True";
                string storeReportQuery = @$"insert into reports(reports) values('{reportText}')";

                SqlConnection con1 = new SqlConnection(dbString);
                con1.Open();
                SqlCommand cmd1 = new SqlCommand(storeReportQuery, con1);
                int count = (int)cmd1.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("Report Submitted !!");
                }
                else
                {
                    MessageBox.Show("Server Side error!!");
                }
                ReportTextBox.Text = "";


            }
        }
    }
}
