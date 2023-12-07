namespace VideoRentalSystem
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            deletebtn = new Button();
            editbtn = new Button();
            addbtn = new Button();
            viewbtn = new Button();
            dgv1 = new DataGridView();
            txtCopies = new TextBox();
            label5 = new Label();
            txtFee = new TextBox();
            label4 = new Label();
            txtGenre = new TextBox();
            label3 = new Label();
            txtMovieName = new TextBox();
            label2 = new Label();
            txtM_Id = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            report = new ComboBox();
            txtMonth = new TextBox();
            label6 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            tabPage3 = new TabPage();
            dgv2 = new DataGridView();
            button2 = new Button();
            txtoid = new TextBox();
            label7 = new Label();
            tabPage4 = new TabPage();
            button3 = new Button();
            dgv3 = new DataGridView();
            txtmid = new TextBox();
            orderdate = new DateTimePicker();
            button4 = new Button();
            label8 = new Label();
            tabPage5 = new TabPage();
            button7 = new Button();
            txtuid = new TextBox();
            button6 = new Button();
            label9 = new Label();
            button5 = new Button();
            dgv4 = new DataGridView();
            tabPage6 = new TabPage();
            button11 = new Button();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            dgv5 = new DataGridView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label10 = new Label();
            txtid = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv2).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv3).BeginInit();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv4).BeginInit();
            tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv5).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(889, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(deletebtn);
            tabPage1.Controls.Add(editbtn);
            tabPage1.Controls.Add(addbtn);
            tabPage1.Controls.Add(viewbtn);
            tabPage1.Controls.Add(dgv1);
            tabPage1.Controls.Add(txtCopies);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(txtFee);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(txtGenre);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(txtMovieName);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(txtM_Id);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(881, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Movies";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // deletebtn
            // 
            deletebtn.BackColor = Color.Red;
            deletebtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            deletebtn.Location = new Point(80, 338);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(75, 37);
            deletebtn.TabIndex = 14;
            deletebtn.Text = "DELETE";
            deletebtn.UseVisualStyleBackColor = false;
            deletebtn.Click += deletebtn_Click;
            // 
            // editbtn
            // 
            editbtn.BackColor = Color.DarkSlateBlue;
            editbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            editbtn.ForeColor = SystemColors.Control;
            editbtn.Location = new Point(152, 290);
            editbtn.Name = "editbtn";
            editbtn.Size = new Size(75, 34);
            editbtn.TabIndex = 13;
            editbtn.Text = "Edit";
            editbtn.UseVisualStyleBackColor = false;
            editbtn.Click += editbtn_Click;
            // 
            // addbtn
            // 
            addbtn.BackColor = Color.LightGreen;
            addbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addbtn.Location = new Point(3, 290);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(75, 28);
            addbtn.TabIndex = 12;
            addbtn.Text = "Add";
            addbtn.UseVisualStyleBackColor = false;
            addbtn.Click += addbtn_Click;
            // 
            // viewbtn
            // 
            viewbtn.Location = new Point(80, 252);
            viewbtn.Name = "viewbtn";
            viewbtn.Size = new Size(75, 23);
            viewbtn.TabIndex = 11;
            viewbtn.Text = "View";
            viewbtn.UseVisualStyleBackColor = true;
            viewbtn.Click += button1_Click;
            // 
            // dgv1
            // 
            dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv1.Location = new Point(240, 20);
            dgv1.Name = "dgv1";
            dgv1.RowTemplate.Height = 25;
            dgv1.Size = new Size(531, 355);
            dgv1.TabIndex = 10;
            // 
            // txtCopies
            // 
            txtCopies.Location = new Point(90, 185);
            txtCopies.Name = "txtCopies";
            txtCopies.Size = new Size(100, 23);
            txtCopies.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 188);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 8;
            label5.Text = "Copies: ";
            // 
            // txtFee
            // 
            txtFee.Location = new Point(90, 147);
            txtFee.Name = "txtFee";
            txtFee.Size = new Size(100, 23);
            txtFee.TabIndex = 7;
            txtFee.TextChanged += textBox4_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 147);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 6;
            label4.Text = "Fee: ";
            // 
            // txtGenre
            // 
            txtGenre.Location = new Point(90, 106);
            txtGenre.Name = "txtGenre";
            txtGenre.Size = new Size(100, 23);
            txtGenre.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 109);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 4;
            label3.Text = "Genre:";
            // 
            // txtMovieName
            // 
            txtMovieName.Location = new Point(90, 67);
            txtMovieName.Name = "txtMovieName";
            txtMovieName.Size = new Size(100, 23);
            txtMovieName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 67);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 2;
            label2.Text = "Movie Name: ";
            // 
            // txtM_Id
            // 
            txtM_Id.Location = new Point(90, 28);
            txtM_Id.Name = "txtM_Id";
            txtM_Id.Size = new Size(100, 23);
            txtM_Id.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 31);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Movie ID: ";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(report);
            tabPage2.Controls.Add(txtMonth);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(881, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Queries";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // report
            // 
            report.FormattingEnabled = true;
            report.Items.AddRange(new object[] { "Most Rented Movies", "Top Renters", "Movies Never Rented", "Monthly Rentals", "Least Rented Genre", "Least Rented Genre in the Month" });
            report.Location = new Point(209, 258);
            report.Name = "report";
            report.Size = new Size(390, 23);
            report.TabIndex = 14;
            // 
            // txtMonth
            // 
            txtMonth.Location = new Point(317, 317);
            txtMonth.Name = "txtMonth";
            txtMonth.Size = new Size(171, 23);
            txtMonth.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(358, 299);
            label6.Name = "label6";
            label6.Size = new Size(80, 15);
            label6.TabIndex = 7;
            label6.Text = "Month: (1-12)";
            // 
            // button1
            // 
            button1.Location = new Point(335, 371);
            button1.Name = "button1";
            button1.Size = new Size(131, 43);
            button1.TabIndex = 6;
            button1.Text = "Query";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 17);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(742, 196);
            dataGridView1.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dgv2);
            tabPage3.Controls.Add(button2);
            tabPage3.Controls.Add(txtoid);
            tabPage3.Controls.Add(label7);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(881, 422);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Returns";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgv2
            // 
            dgv2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv2.Location = new Point(187, 12);
            dgv2.Name = "dgv2";
            dgv2.RowTemplate.Height = 25;
            dgv2.Size = new Size(597, 389);
            dgv2.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(66, 139);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Returned";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtoid
            // 
            txtoid.Location = new Point(66, 81);
            txtoid.Name = "txtoid";
            txtoid.Size = new Size(69, 23);
            txtoid.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(54, 54);
            label7.Name = "label7";
            label7.Size = new Size(50, 15);
            label7.TabIndex = 0;
            label7.Text = "OrderId:";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(button3);
            tabPage4.Controls.Add(dgv3);
            tabPage4.Controls.Add(txtmid);
            tabPage4.Controls.Add(orderdate);
            tabPage4.Controls.Add(button4);
            tabPage4.Controls.Add(label8);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(881, 422);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Rent a Movie";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(92, 229);
            button3.Name = "button3";
            button3.Size = new Size(75, 42);
            button3.TabIndex = 10;
            button3.Text = "Order!";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dgv3
            // 
            dgv3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv3.Location = new Point(274, 32);
            dgv3.Name = "dgv3";
            dgv3.RowTemplate.Height = 25;
            dgv3.Size = new Size(559, 359);
            dgv3.TabIndex = 6;
            // 
            // txtmid
            // 
            txtmid.Location = new Point(92, 141);
            txtmid.Name = "txtmid";
            txtmid.Size = new Size(99, 23);
            txtmid.TabIndex = 8;
            // 
            // orderdate
            // 
            orderdate.Location = new Point(47, 174);
            orderdate.Name = "orderdate";
            orderdate.Size = new Size(176, 23);
            orderdate.TabIndex = 9;
            // 
            // button4
            // 
            button4.Location = new Point(92, 61);
            button4.Name = "button4";
            button4.Size = new Size(75, 42);
            button4.TabIndex = 5;
            button4.Text = "Browse";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(63, 123);
            label8.Name = "label8";
            label8.Size = new Size(36, 15);
            label8.TabIndex = 7;
            label8.Text = "M_Id:";
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(button7);
            tabPage5.Controls.Add(txtuid);
            tabPage5.Controls.Add(button6);
            tabPage5.Controls.Add(label9);
            tabPage5.Controls.Add(button5);
            tabPage5.Controls.Add(dgv4);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(881, 422);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Orders";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(567, 350);
            button7.Name = "button7";
            button7.Size = new Size(173, 46);
            button7.TabIndex = 5;
            button7.Text = "Filter";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // txtuid
            // 
            txtuid.Location = new Point(299, 373);
            txtuid.Name = "txtuid";
            txtuid.Size = new Size(165, 23);
            txtuid.TabIndex = 4;
            // 
            // button6
            // 
            button6.Location = new Point(358, 272);
            button6.Name = "button6";
            button6.Size = new Size(173, 46);
            button6.TabIndex = 3;
            button6.Text = "View Overdue";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(255, 343);
            label9.Name = "label9";
            label9.Size = new Size(92, 15);
            label9.TabIndex = 2;
            label9.Text = "Filter by User ID:";
            // 
            // button5
            // 
            button5.Location = new Point(126, 272);
            button5.Name = "button5";
            button5.Size = new Size(173, 46);
            button5.TabIndex = 1;
            button5.Text = "View All";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // dgv4
            // 
            dgv4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv4.Location = new Point(87, 32);
            dgv4.Name = "dgv4";
            dgv4.RowTemplate.Height = 25;
            dgv4.Size = new Size(702, 214);
            dgv4.TabIndex = 0;
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(txtid);
            tabPage6.Controls.Add(label10);
            tabPage6.Controls.Add(button11);
            tabPage6.Controls.Add(button10);
            tabPage6.Controls.Add(button9);
            tabPage6.Controls.Add(button8);
            tabPage6.Controls.Add(dgv5);
            tabPage6.Location = new Point(4, 24);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(881, 422);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Users";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Location = new Point(581, 361);
            button11.Name = "button11";
            button11.Size = new Size(109, 42);
            button11.TabIndex = 4;
            button11.Text = "Delete";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button10
            // 
            button10.Location = new Point(415, 276);
            button10.Name = "button10";
            button10.Size = new Size(109, 42);
            button10.TabIndex = 3;
            button10.Text = "Edit";
            button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(243, 276);
            button9.Name = "button9";
            button9.Size = new Size(109, 42);
            button9.TabIndex = 2;
            button9.Text = "Add";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.Location = new Point(82, 276);
            button8.Name = "button8";
            button8.Size = new Size(109, 42);
            button8.TabIndex = 1;
            button8.Text = "View";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // dgv5
            // 
            dgv5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv5.Location = new Point(47, 25);
            dgv5.Name = "dgv5";
            dgv5.RowTemplate.Height = 25;
            dgv5.Size = new Size(675, 222);
            dgv5.TabIndex = 0;
            dgv5.CellContentClick += dgv5_CellContentClick;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(359, 378);
            label10.Name = "label10";
            label10.Size = new Size(46, 15);
            label10.TabIndex = 5;
            label10.Text = "User Id:";
            // 
            // txtid
            // 
            txtid.Location = new Point(409, 377);
            txtid.Name = "txtid";
            txtid.Size = new Size(100, 23);
            txtid.TabIndex = 6;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 450);
            Controls.Add(tabControl1);
            Name = "Form5";
            Text = "Form5";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv2).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv3).EndInit();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv4).EndInit();
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox txtM_Id;
        private Label label1;
        private TextBox txtCopies;
        private Label label5;
        private TextBox txtFee;
        private Label label4;
        private TextBox txtGenre;
        private Label label3;
        private TextBox txtMovieName;
        private Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridView dgv1;
        private Button viewbtn;
        private Button addbtn;
        private Button editbtn;
        private Button deletebtn;
        private DataGridView dataGridView1;
        private TextBox txtMonth;
        private Label label6;
        private Button button1;
        private ComboBox report;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Button button2;
        private TextBox txtoid;
        private Label label7;
        private DataGridView dgv2;
        private Button button3;
        private DataGridView dgv3;
        private TextBox txtmid;
        private DateTimePicker orderdate;
        private Button button4;
        private Label label8;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private DataGridView dgv4;
        private Label label9;
        private Button button5;
        private Button button7;
        private TextBox txtuid;
        private Button button6;
        private Button button8;
        private DataGridView dgv5;
        private Button button11;
        private Button button10;
        private Button button9;
        private TextBox txtid;
        private Label label10;
    }
}