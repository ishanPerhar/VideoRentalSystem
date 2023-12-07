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
        private int userId;
        public empdashboard(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            // Create new Form5
            Form5 form5 = new Form5(userId);

            form5.TopLevel = false;

            form5.FormBorderStyle = FormBorderStyle.None;

            // fill the entire panel
            form5.Dock = DockStyle.Fill;

            // Add Form5 to panel
            panel3.Controls.Add(form5);

            // Show Form
            form5.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Create new login form
            regForm regform = new regForm();


            regform.TopLevel = false;

            regform.FormBorderStyle = FormBorderStyle.None;

            //fill the entire panel3
            regform.Dock = DockStyle.Fill;

           
            panel3.Controls.Add(regform);

            // Show Form
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
