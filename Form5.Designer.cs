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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
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
            tabPage1.Size = new Size(792, 422);
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
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Actors";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form5";
            Text = "Form5";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv1).EndInit();
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
    }
}