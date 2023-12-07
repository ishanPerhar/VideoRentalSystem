using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VideoRentalSystem
{
    public partial class Form6 : Form
    {
        private int userId;
        public Form6(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }


        String connectionString = "Server = DESKTOP-D0DDBSH; Database = Project; Trusted_Connection = yes;";

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Open the connection
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query 
                    string query = "SELECT * FROM Movies WHERE Copies > 0";

                    // fetch data
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                    // store data
                    DataTable dataTable = new DataTable();

                    // fill the table
                    adapter.Fill(dataTable);

                    dgv1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            String connectionString = "Server = DESKTOP-D0DDBSH; Database = Project; Trusted_Connection = yes;";
            int userId = this.userId;
            int movieId;




            if (int.TryParse(txtmid.Text, out movieId))
            {
                DateTime orderDate = orderdate.Value;
                //add 7 days assuming one week rentals
                DateTime returnDate = orderDate.AddDays(7);
                // Initial status
                string status = "Not Returned";

                // Insert order into database
                string query = "INSERT INTO Orders (userid, M_Id, OrderDate, ReturnDate, Status) VALUES (@UserId, @MovieId, @OrderDate, @ReturnDate, @Status)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@UserId", userId);
                        command.Parameters.AddWithValue("@MovieId", movieId);
                        command.Parameters.AddWithValue("@OrderDate", orderDate);
                        command.Parameters.AddWithValue("@ReturnDate", returnDate);
                        command.Parameters.AddWithValue("@Status", status);

                        command.ExecuteNonQuery();


                        // Update available copies in the Movies table
                        string updateQuery = "UPDATE Movies SET Copies = Copies - 1 WHERE M_Id = @MovieId";

                        using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                        {
                            updateCommand.Parameters.AddWithValue("@MovieId", movieId);

                            updateCommand.ExecuteNonQuery();

                            MessageBox.Show("Order placed successfully.");

                            RefreshDataGridView();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid movie ID. Please enter a valid numeric value.");
            }

        }
        private int GenerateUniqueOrderId()
        {
            // Combine timestamp and a random number to create a unique integer
            return (int)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds + new Random().Next(1, 1000);
        }
        private void RefreshDataGridView()
        {
            try
            {
                // Open the connection
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query
                    string query = "SELECT * FROM Movies";

                    // fetch data
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                    // Create datatable
                    DataTable dataTable = new DataTable();

                    // Fill the DataTable
                    adapter.Fill(dataTable);

                    dgv1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error refreshing DataGridView: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Open the connection
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // query to select the Orders of the user 
                    string query = "SELECT Movies.Movie_name, Orders.ReturnDate, Orders.Status  FROM Orders " +
                       "INNER JOIN Movies ON Orders.M_Id = Movies.M_Id " +
                       "WHERE Orders.userid = @UserID";


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        //Add the user ID
                        command.Parameters.AddWithValue("@UserID", userId);

                        //fetch data
                        SqlDataAdapter adapter = new SqlDataAdapter(command);

                        //store data
                        DataTable dataTable = new DataTable();

                        //Fill the datatable
                        adapter.Fill(dataTable);

                        //Connect the datatable to the datagrid
                        dgv2.DataSource = dataTable;
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
