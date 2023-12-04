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
    public partial class dashboard : Form
    {
        private int userId;
        public dashboard(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            //close form
            this.Close();

            //exit app
            Application.Exit();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            panel3.BringToFront();
            // Create an instance of Form5
            Form6 form6 = new Form6(userId);

            // Set the TopLevel property to false to allow it to be embedded in panel3
            form6.TopLevel = false;

            // Set the FormBorderStyle property to None to remove the border of Form5
            form6.FormBorderStyle = FormBorderStyle.None;

            // Set the Dock property to Fill to make Form5 fill the entire panel3
            form6.Dock = DockStyle.Fill;

            // Add Form5 to panel3
            panel3.Controls.Add(form6);

            // Show Form5
            form6.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
