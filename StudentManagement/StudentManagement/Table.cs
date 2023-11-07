using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StudentManagement
{
    public partial class Table : Form
    {
        private MySqlConnection connection;

        public Table(MySqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }

        private void Table_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }



        private void LoadStudents()
        {
            try
            {
                string query = "SELECT * FROM students";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


    }
}
