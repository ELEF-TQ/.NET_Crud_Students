using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StudentManagement
{
    public partial class MainForm : Form
    {
        private MySqlConnection connection;  // Add this field to store the connection

        public MainForm(MySqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;  // Store the connection in the field
        }

      

        private void MainForm_Load(object sender, EventArgs e)
        {
            // You can use the 'connection' field here if needed
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // You can access the 'connection' field here
            Table tableForm = new Table(connection);
            tableForm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // You can use the 'connection' field here if needed
        }


        private void Ajouter_Click(object sender, EventArgs e)
        {
            // Collect input values from your form fields
            string code = Code.Text;  // Replace "textBoxCode" with the actual name of your TextBox
            string nom = Nom.Text;    // Replace "textBoxNom" with the actual name of your TextBox
            string prenom = Prenom.Text;  // Replace "textBoxPrenom" with the actual name of your TextBox
            string filliere = Filiere.Text;  // Replace "textBoxFilliere" with the actual name of your TextBox

            try
            {
                // Construct the SQL INSERT statement
                string insertQuery = "INSERT INTO students (code, nom, prenom, filliere) " +
                   "VALUES (@code, @nom, @prenom, @filliere)";


                using (MySqlCommand cmd = new MySqlCommand(insertQuery, connection))
                {
                    // Add parameters to the SQL command to avoid SQL injection
                    cmd.Parameters.AddWithValue("@code", code);
                    cmd.Parameters.AddWithValue("@nom", nom);
                    cmd.Parameters.AddWithValue("@prenom", prenom);
                    cmd.Parameters.AddWithValue("@filliere", filliere);

                    // Execute the SQL command to insert the data
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data saved successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to save data.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Vider_Click(object sender, EventArgs e)
        {
            Code.Text = string.Empty;
            Nom.Text = string.Empty;
            Prenom.Text = string.Empty;
            Filiere.Text = string.Empty;
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            // Get the code you want to search for
            string codeToUpdate = Code.Text;  // Assuming textBoxCode is the name of your code input TextBox

            // Check if the code is provided
            if (string.IsNullOrEmpty(codeToUpdate))
            {
                MessageBox.Show("Please enter the student code to update.");
                return;
            }

            // Assuming textBoxNom, textBoxPrenom, and textBoxFilliere are the names of your TextBox controls for name, prenom, and filliere
            string nom = Nom.Text;
            string prenom = Prenom.Text;
            string filliere = Filiere.Text;

            try
            {
                // Construct the SQL UPDATE statement
                string updateQuery = "UPDATE students SET nom = @nom, prenom = @prenom, filliere = @filliere WHERE code = @code";

                using (MySqlCommand cmd = new MySqlCommand(updateQuery, connection))
                {
                    // Add parameters to the SQL command to avoid SQL injection
                    cmd.Parameters.AddWithValue("@code", codeToUpdate);
                    cmd.Parameters.AddWithValue("@nom", nom);
                    cmd.Parameters.AddWithValue("@prenom", prenom);
                    cmd.Parameters.AddWithValue("@filliere", filliere);

                    // Execute the SQL command to update the data
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Student information updated successfully.");
                        // Clear the fields after the update
                        Nom.Text = string.Empty;
                        Prenom.Text = string.Empty;
                        Filiere.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("No student found with the provided code.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            // Get the code you want to search for
            string codeToDelete = Code.Text;  // Assuming textBoxCode is the name of your code input TextBox

            // Check if the code is provided
            if (string.IsNullOrEmpty(codeToDelete))
            {
                MessageBox.Show("Please enter the student code to delete.");
                return;
            }

            try
            {
                // Construct the SQL DELETE statement
                string deleteQuery = "DELETE FROM students WHERE code = @code";

                using (MySqlCommand cmd = new MySqlCommand(deleteQuery, connection))
                {
                    // Add the code parameter to the SQL command
                    cmd.Parameters.AddWithValue("@code", codeToDelete);

                    // Execute the SQL command to delete the data
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Student deleted successfully.");
                        // Clear the code field after the deletion
                        Code.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("No student found with the provided code.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Chercher_Click(object sender, EventArgs e)
        {
            // Get the code you want to search for
            string codeToSearch = Code.Text;  // Assuming textBoxCode is the name of your code input TextBox

            // Check if the code is provided
            if (string.IsNullOrEmpty(codeToSearch))
            {
                MessageBox.Show("Please enter the student code to search.");
                return;
            }

            try
            {
                // Construct the SQL SELECT statement
                string selectQuery = "SELECT * FROM students WHERE code = @code";

                using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                {
                    // Add the code parameter to the SQL command
                    cmd.Parameters.AddWithValue("@code", codeToSearch);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // If a student with the given code is found, populate other fields
                            Nom.Text = reader["nom"].ToString();  // Assuming textBoxNom is the name of your nom input TextBox
                            Prenom.Text = reader["prenom"].ToString();  // Assuming textBoxPrenom is the name of your prenom input TextBox
                            Filiere.Text = reader["filliere"].ToString();  // Assuming textBoxFilliere is the name of your filliere input TextBox
                        }
                        else
                        {
                            MessageBox.Show("No student found with the provided code.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
}
