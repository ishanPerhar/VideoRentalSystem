using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VideoRentalSystem
{
    public partial class Form5 : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        String connectionString = "Server = DESKTOP-D0DDBSH; Database = Project; Trusted_Connection = yes;";

        public Form5()
        {
            InitializeComponent();





            SqlConnection myConnection = new SqlConnection(connectionString);

            try
            {
                myConnection.Open(); // Open connection
                myCommand = new SqlCommand();
                myCommand.Connection = myConnection; // Link the command stream to the connection
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
                this.Close();
            }

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Open the connection
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to select all from the Movies table
                    string query = "SELECT * FROM Movies";

                    // SqlDataAdapter to fetch data
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                    // Create a DataTable to store data
                    DataTable dataTable = new DataTable();

                    // fill the datatable with data from the table
                    adapter.Fill(dataTable);

                    // connect the datatable to the datagrid
                    dgv1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            // convert user inputs
            if (!int.TryParse(txtM_Id.Text, out int mId))
            {
                // set a default value
                mId = 0;
            }

            string movieName = txtMovieName.Text;
            string genre = txtGenre.Text;

            if (!int.TryParse(txtFee.Text, out int fee))
            {
                // set a default value
                fee = 5;
            }

            if (!int.TryParse(txtCopies.Text, out int copies))
            {
                // set a default value
                copies = 0;
            }

            try
            {
                // Open the connection
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // make SQL query
                    string query = "INSERT INTO Movies (M_Id, Movie_name, Genre, Fee, Copies) " +
                                   "VALUES (@M_Id, @MovieName, @Genre, @Fee, @Copies)";

                    // Create and execute command
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@M_Id", mId);
                        command.Parameters.AddWithValue("@MovieName", movieName);
                        command.Parameters.AddWithValue("@Genre", genre);
                        command.Parameters.AddWithValue("@Fee", fee);
                        command.Parameters.AddWithValue("@Copies", copies);


                        command.ExecuteNonQuery();

                        MessageBox.Show("Movie added successfully!");

                        //refresh data grid view 
                        RefreshDataGridView();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Query1()
        {
            try
            {
                string query = @"
            SELECT
                m.M_Id,
                m.Movie_name,
                COUNT(o.OrderID) AS Rentals
            FROM
                Movies m
            LEFT JOIN
                Orders o ON m.M_Id = o.M_Id
            GROUP BY
                m.M_Id, m.Movie_name
            ORDER BY
                Rentals DESC;";

                ExecuteAndDisplayQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Query2()
        {
            try
            {
                string query = @"
            SELECT
                u.user_id,
                u.firstname,
                COUNT(o.OrderID) AS RentalCount
            FROM
                Users u
            LEFT JOIN
                Orders o ON u.user_id = o.userid
            GROUP BY
                u.user_id, u.firstname
            ORDER BY
                RentalCount DESC;";

                ExecuteAndDisplayQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Query3()
        {
            try
            {
                string query = @"
            SELECT
                M_Id,
                Movie_name
            FROM
                Movies
            WHERE
                M_Id NOT IN (SELECT DISTINCT M_Id FROM Orders);";

                ExecuteAndDisplayQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Query4()
        {
            try
            {
                int selectedMonth = Convert.ToInt32(txtMonth.Text);

                //SQL query
                string query = $"SELECT COUNT(OrderID) AS RentalCount FROM Orders WHERE MONTH(OrderDate) = {selectedMonth};";

                //show in grid
                ExecuteAndDisplayQuery(query);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Query5()
        {
            try
            {
                string query = @"
            SELECT
                m.Genre,
                COUNT(o.OrderID) AS RentalCount
            FROM
                Movies m
            LEFT JOIN
                Orders o ON m.M_Id = o.M_Id
            GROUP BY
                m.Genre
            ORDER BY
                RentalCount ASC;";

                ExecuteAndDisplayQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExecuteAndDisplayQuery(string query)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            // Get user input
            if (!int.TryParse(txtM_Id.Text, out int MId))
            {
                // If invalid input
                MId = 0;
            }

            try
            {
                // Open the connection
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to delete a row from the Movies table
                    string query = "DELETE FROM Movies WHERE M_Id = @DeleteMId";

                    // Create and execute the SQL command
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameter
                        command.Parameters.AddWithValue("@DeleteMId", MId);

                        // Execute the command
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Movie deleted successfully!");

                            //refresh grid
                            RefreshDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("No movie found with the specified Movie ID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void RefreshDataGridView()
        {
            try
            {
                // Open the connection
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to select all columns from the Movies table
                    string query = "SELECT * FROM Movies";

                    // Create a SqlDataAdapter to fetch data
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                    // Create a DataTable to store the fetched data
                    DataTable dataTable = new DataTable();

                    // Fill the DataTable with data from the Movies table
                    adapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView
                    dgv1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error refreshing DataGridView: " + ex.Message);
            }
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            // Get user input
            int.TryParse(txtM_Id.Text, out int mIdToEdit);
            string movieName = txtMovieName.Text;
            string genre = txtGenre.Text;

            // convert to int
            int.TryParse(txtFee.Text, out int feeToEdit);
            int.TryParse(txtCopies.Text, out int copiesToEdit);

            try
            {
                // Open the connection
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to update
                    string query = "UPDATE Movies SET Movie_name = @MovieName, Genre = @Genre, Fee = @Fee, Copies = @Copies " +
                                   "WHERE M_Id = @M_IdToEdit";

                    // Create and execute the SQL command
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters
                        command.Parameters.AddWithValue("@MovieName", movieName);
                        command.Parameters.AddWithValue("@Genre", genre);
                        command.Parameters.AddWithValue("@Fee", feeToEdit);
                        command.Parameters.AddWithValue("@Copies", copiesToEdit);
                        command.Parameters.AddWithValue("@M_IdToEdit", mIdToEdit);


                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Movie edit was successful!");

                            // Refresh the DataGridView
                            RefreshDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("No movie found to edit.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Get the selected item from the ComboBox
                string selectedReport = report.SelectedItem.ToString();

                // Determine which query to execute based on the selected report
                switch (selectedReport)
                {
                    case "Most Rented Movies":
                        Query1();
                        break;

                    case "Top Renters":
                        Query2();
                        break;

                    case "Movies Never Rented":
                        Query3();
                        break;

                    case "Monthly Rentals":
                        Query4();
                        break;

                    case "Least Rented Genre":
                        Query5();
                        break;

                    default:
                        MessageBox.Show("No Report selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
