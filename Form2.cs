using Microsoft.VisualBasic.ApplicationServices;
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

namespace VideoRentalSystem
{
    public partial class regForm : Form
    {
        private string connectionString = "Server = DESKTOP-D0DDBSH; Database = Project; Trusted_Connection = yes;";
        public regForm()
        {
            InitializeComponent();
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //new loginfrom().Show();
            //this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //generate a userid
            int userId = GenerateUniqueUserId();
            // Get user inputs from the form
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string firstname = txtFirstName.Text;
            string lastname = txtLastname.Text;
            string email = txtEmail.Text;
            string phonenum = txtPhoneNum.Text;
            string address = txtAddress.Text;
            string city = txtCity.Text;
            string state = txtState.Text;
            string zipcode = txtZipcode.Text;
            string creditcard = txtCreditCard.Text;
            int employee = chkEmployee.Checked ? 1 : 0;

            try
            {
                // Open the connection
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();



                    // Create the SQL query
                    string query = "INSERT INTO users (user_id, username, password, firstname, lastname, email, phonenum, address, city, state, zipcode, creditcard, employee) " +
               "VALUES (@user_id, @username, @password, @firstname, @lastname, @email, @phonenum, @address, @city, @state, @zipcode, @creditcard, @employee)";

                    // Create and execute the SQL command
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to prevent SQL injection
                        command.Parameters.AddWithValue("@user_id", userId);
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@firstname", firstname);
                        command.Parameters.AddWithValue("@lastname", lastname);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@phonenum", phonenum);
                        command.Parameters.AddWithValue("@address", address);
                        command.Parameters.AddWithValue("@city", city);
                        command.Parameters.AddWithValue("@state", state);
                        command.Parameters.AddWithValue("@zipcode", zipcode);
                        command.Parameters.AddWithValue("@creditcard", creditcard);
                        command.Parameters.AddWithValue("@employee", employee);

                        // Execute the command
                        command.ExecuteNonQuery();

                        MessageBox.Show("User registered successfully!");

                        // close current window
                        this.Close();

                        // show login form
                        loginfrom loginForm = new loginfrom();
                        loginForm.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private int GenerateUniqueUserId()
        {
            // Combine timestamp and a random number to create a unique integer
            return (int)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds + new Random().Next(1, 1000);
        }
    }
}
