using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StudentManagement
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Database connection details
            string server = "localhost";
            string database = "school_jee";
            string port = "3306";
            string username = "root";
            string password = "";

            string connectionString = $"Server={server};Port={port};Database={database};User ID={username};Password={password};";

            // Create a MySqlConnection instance
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                Application.Run(new MainForm(connection)); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
