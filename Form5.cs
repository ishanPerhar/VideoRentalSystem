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
    }
}
