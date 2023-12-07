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

        private int userId;

        String connectionString = "Server = DESKTOP-D0DDBSH; Database = Project; Trusted_Connection = yes;";

        public Form5(int userId)
        {
            InitializeComponent();

            this.userId = userId;




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

                    // SQL query
                    string query = "SELECT * FROM Movies";

                    // fetch data
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                    // store data
                    DataTable dataTable = new DataTable();

                    // fill the datatable with data from the table
                    adapter.Fill(dataTable);

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
                        RefreshDataGridView(dgv1);
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
                string query = $"SELECT COUNT(OrderID) AS RentalCount " +
                    $"FROM Orders " +
                    $"WHERE MONTH(OrderDate) = {selectedMonth};";

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
        private void Query6()
        {
            try
            {
                int selectedMonth = Convert.ToInt32(txtMonth.Text);
                string query = @"
            SELECT
                m.Genre,
                COUNT(o.OrderID) AS RentalCount
            FROM
                Movies m
            LEFT JOIN
                Orders o ON m.M_Id = o.M_Id AND MONTH(o.OrderDate) = " + selectedMonth + @"
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
                //open connection
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    //execute query, get data, fill datatable, bind to dgv
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
                            RefreshDataGridView(dgv1);
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
        private void RefreshDataGridView(DataGridView dgv)
        {
            try
            {
                // Open connection
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query
                    string query = "SELECT * FROM Movies";

                    // fetch data
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                    // Create a DataTable to store data
                    DataTable dataTable = new DataTable();

                    // Fill dataTable
                    adapter.Fill(dataTable);

                    // add to datadridview
                    dgv.DataSource = dataTable;
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
                            RefreshDataGridView(dgv1);
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
                // Get item from the ComboBox
                string selectedReport = report.SelectedItem.ToString();

                // switch for selected report
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
                    case "Least Rented Genre in the Month":
                        Query6();
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

        private void button2_Click(object sender, EventArgs e)
        {
            // Get the order ID
            if (int.TryParse(txtoid.Text, out int orderId))
            {
                // Call function to execute query and update status
                UpdateStatusInDatabase(orderId);
                //load orders table into datagridview
                LoadOrdersIntoDataGridView();
            }
            else
            {
                MessageBox.Show("Invalid order ID.");
            }
        }
        private void UpdateStatusInDatabase(int orderId)
        {
            try
            {
                // Open the connection
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // update the Status column
                    string query = "UPDATE Orders SET Status = 'Returned' WHERE OrderId = @OrderId";


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add the OrderId
                        command.Parameters.AddWithValue("@OrderId", orderId);

                        // Execute query
                        int rowsAffected = command.ExecuteNonQuery();



                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Status updated successfully.");

                        }
                        else
                        {
                            MessageBox.Show("Order ID not found. No rows updated.");

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void LoadOrdersIntoDataGridView()
        {
            try
            {
                // Open the connection
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // query Orders table
                    string query = "SELECT * FROM Orders";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // fetch data
                        SqlDataAdapter adapter = new SqlDataAdapter(command);

                        // store data
                        DataTable dataTable = new DataTable();

                        // Fill the datatable
                        adapter.Fill(dataTable);

                        dgv2.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                // Open the connection
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to select all from the Movies table
                    string query = "SELECT * FROM Movies WHERE Copies > 0";

                    // fetch data
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                    // store data
                    DataTable dataTable = new DataTable();

                    // fill the datatable
                    adapter.Fill(dataTable);

                    dgv3.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
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

                            RefreshDataGridView(dgv3);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid movie ID. Please enter a valid numeric value.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                String connectionString = "Server = DESKTOP-D0DDBSH; Database = Project; Trusted_Connection = yes;";
                // Create a SqlConnection
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    // Open the SQL connection
                    sqlConnection.Open();

                    // fetch data
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Orders", sqlConnection);

                    // store the data
                    DataTable dataTable = new DataTable();

                    // Fill the DataTable
                    sqlDataAdapter.Fill(dataTable);

                    dgv4.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {

                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    // Open connection
                    sqlConnection.Open();

                    // Create a query
                    string query = "SELECT * FROM Orders WHERE Status = 'Not Returned' AND ReturnDate < @CurrentDate";
                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        // Add the current date
                        sqlCommand.Parameters.AddWithValue("@CurrentDate", DateTime.Now);

                        // fetch data
                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                        // store data
                        DataTable dataTable = new DataTable();

                        sqlDataAdapter.Fill(dataTable);

                        dgv4.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the UserID convert it to an integer
                if (int.TryParse(txtuid.Text, out int userId))
                {

                    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                    {
                        // Open the SQL connection
                        sqlConnection.Open();

                        // Create a query
                        string query = "SELECT * FROM Orders WHERE UserID = @UserID";
                        using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                        {
                            // Add the UserID
                            sqlCommand.Parameters.AddWithValue("@UserID", userId);

                            // fetch data
                            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                            // store the data
                            DataTable dataTable = new DataTable();

                            // Fill the DataTable 
                            sqlDataAdapter.Fill(dataTable);

                            dgv4.DataSource = dataTable;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid UserID (numeric value).");
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    // Open connection
                    sqlConnection.Open();

                    // Create a query
                    string query = "SELECT * FROM Users";
                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        // fetch data
                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                        // store the data
                        DataTable dataTable = new DataTable();

                        // Fill the DataTable
                        sqlDataAdapter.Fill(dataTable);


                        dgv5.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgv5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Create an instance of registration form
            regForm regForm = new regForm();

            // Show form
            regForm.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the user_id  convert it to an int
                if (int.TryParse(txtid.Text, out int userId))
                {

                    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                    {
                        // Open connection
                        sqlConnection.Open();

                        // Create query
                        string query = "DELETE FROM Users WHERE user_id = @UserID";
                        using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                        {
                            // Add the user_id
                            sqlCommand.Parameters.AddWithValue("@UserID", userId);

                            // Execute query
                            int rowsAffected = sqlCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("User deleted successfully.");
                            }
                            else
                            {
                                MessageBox.Show("error occurred");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid user_id");
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
