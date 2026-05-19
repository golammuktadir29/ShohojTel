using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ShohojTel
{
    public partial class Customer : Form
    {
        private string username;
        public Customer()
        {
            InitializeComponent();
        }
        public Customer(string name)
        {
            InitializeComponent();
            this.username = name;
            this.Load += Customer_Load;
        }



        private void Customer_Load(object sender, EventArgs e)
        {
            label1.Text = $"Welcome to ShohojTel,\n{username}";
            dashBoardUserControl1.Hide();
            ticketCounterUserControl1.Show();
            reportsUserControl1.Hide();

            
            HighlightButton(TicketCounterBtn);

        }
        private void HighlightButton(Button btn)
        {
            DashBoardBtn.BackColor = SystemColors.Control;
            TicketCounterBtn.BackColor = SystemColors.Control;
            ReportsBtn.BackColor = SystemColors.Control;

            btn.BackColor = Color.Black;
           
        }

        private void ticketCounterUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TicketCounterBtn_Click(object sender, EventArgs e)
        {
            ticketCounterUserControl1.Show();
            reportsUserControl1.Hide();
            dashBoardUserControl1.Hide();
            HighlightButton(TicketCounterBtn);

        }

        private void DashBoardBtn_Click(object sender, EventArgs e)
        {
            dashBoardUserControl1.Show();
            ticketCounterUserControl1.Hide();
            reportsUserControl1.Hide();
            HighlightButton(DashBoardBtn);
        }

        private void ReportsBtn_Click(object sender, EventArgs e)
        {
            reportsUserControl1.Show();
            dashBoardUserControl1.Hide();
            ticketCounterUserControl1.Hide();
            HighlightButton(ReportsBtn);

        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            Login LoginForm = new Login();
            LoginForm.Show();
            this.Visible = false;

        }
    }
}
