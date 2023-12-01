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
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        public loginfrom()
        {
            InitializeComponent();

            String connectionString = "Server = DESKTOP-D0DDBSH; Database = Project; Trusted_Connection = yes;";

            SqlConnection myConnection = new SqlConnection(connectionString); // Timeout in seconds

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

        

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new regForm().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myConnection.Open();
            string login = "SELECT * FROM users WHERE username= '" + usertxt.Text + "' and password= '" +passtxt.Text+ "' ";
            myCommand = new SqlCommand(login, myConnection);
            myReader = myCommand.ExecuteReader();

            if (myReader.Read() == true)
            {
                new dashboard().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Login", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usertxt.Text = "";
                passtxt.Text = "";
                usertxt.Focus();
            }
        }
    }
}