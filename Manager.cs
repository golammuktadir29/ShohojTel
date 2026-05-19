using Microsoft.Data.SqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ShohojTel
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }



        private void ShowTicketBtn_Click(object sender, EventArgs e)
        {
            string dbString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=registerUser;Integrated Security=True;Trust Server Certificate=True";
            string checkTicketQuery = $"select * from ticket";


            SqlConnection con = new SqlConnection(dbString);
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(checkTicketQuery, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);



            TicketDataGridView.DataSource = null;
            TicketDataGridView.Columns.Clear();
            TicketDataGridView.AutoGenerateColumns = true;
            TicketDataGridView.DataSource = dataTable;

            con.Close();


        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Login login1 = new Login();
            login1.Visible = true;
            this.Visible = false;

        }
    }
}
