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

namespace VideoRentalSystem
{
    public partial class loginfrom : Form
    {
        //public SqlConnection myConnection;
        //public SqlCommand myCommand;
        //public SqlDataReader myReader;

        public loginfrom()
        {
            InitializeComponent();

            String connectionString = "Server = DESKTOP-D0DDBSH; Database = Project; Trusted_Connection = yes;";

            SqlConnection myConnection = new SqlConnection(connectionString); // Timeout in seconds

            try
            {
                //myConnection.Open(); // Open connection
                //myCommand = new SqlCommand();
                //myCommand.Connection = myConnection; // Link the command stream to the connection
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
                this.Close();
            }
        }

        

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new regForm().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String connectionString = "Server = DESKTOP-D0DDBSH; Database = Project; Trusted_Connection = yes;";
            string username = usertxt.Text;
            string password = passtxt.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT user_id, username, employee FROM users WHERE username = @Username AND password = @Password";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int userId = reader.GetInt32(0);
                            string retrievedUsername = reader.GetString(1);
                            int userType = reader.GetInt32(2);

                            // Perform actions based on successful login
                            if (userType == 1)
                            {
                                // Close the current login form
                                this.Hide();

                                // Open the Employee Dashboard form
                                empdashboard empDashboardForm = new empdashboard(userId);
                                empDashboardForm.ShowDialog();
                            }
                            else
                            {
                                // Close the current login form
                                this.Hide();

                                // Open the Dashboard form
                                dashboard dashboardForm = new dashboard(userId);
                                dashboardForm.ShowDialog();
                            }

                            MessageBox.Show("Login successful!");
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password");
                           
                        }
                    }
                }
            }
        }
        private int GenerateUniqueUserId()
        {
            //create a unique integer
            return (int)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds + new Random().Next(1, 1000);
        }
    }
} 