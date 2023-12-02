using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoRentalSystem
{
    public partial class empdashboard : Form
    {
        public empdashboard()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Create an instance of Form5
            Form5 form5 = new Form5();

            // Set the TopLevel property to false to allow it to be embedded in panel3
            form5.TopLevel = false;

            // Set the FormBorderStyle property to None to remove the border of Form5
            form5.FormBorderStyle = FormBorderStyle.None;

            // Set the Dock property to Fill to make Form5 fill the entire panel3
            form5.Dock = DockStyle.Fill;

            // Add Form5 to panel3
            panel3.Controls.Add(form5);

            // Show Form5
            form5.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Create an instance of login form
            regForm regform = new regForm();

            // Set the TopLevel property to false to allow it to be embedded in panel3
            regform.TopLevel = false;

            // Set the FormBorderStyle property to None to remove the border of Form5
            regform.FormBorderStyle = FormBorderStyle.None;

            // Set the Dock property to Fill to make Form5 fill the entire panel3
            regform.Dock = DockStyle.Fill;

            // Add Form5 to panel3
            panel3.Controls.Add(regform);

            // Show Form5
            regform.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //close form
            this.Close();

            //exit app
            Application.Exit();
        }
    }
}
