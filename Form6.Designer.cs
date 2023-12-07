namespace VideoRentalSystem
{
    partial class Form6
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
            button2 = new Button();
            orderdate = new DateTimePicker();
            txtmid = new TextBox();
            label1 = new Label();
            button1 = new Button();
            dgv1 = new DataGridView();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            dgv2 = new DataGridView();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv2).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(50, 203);
            button2.Name = "button2";
            button2.Size = new Size(75, 42);
            button2.TabIndex = 4;
            button2.Text = "Order!";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // orderdate
            // 
            orderdate.Location = new Point(5, 148);
            orderdate.Name = "orderdate";
            orderdate.Size = new Size(176, 23);
            orderdate.TabIndex = 3;
            // 
            // txtmid
            // 
            txtmid.Location = new Point(50, 115);
            txtmid.Name = "txtmid";
            txtmid.Size = new Size(99, 23);
            txtmid.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 97);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 1;
            label1.Text = "M_Id:";
            // 
            // button1
            // 
            button1.Location = new Point(50, 35);
            button1.Name = "button1";
            button1.Size = new Size(75, 42);
            button1.TabIndex = 0;
            button1.Text = "Browse";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dgv1
            // 
            dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv1.Location = new Point(232, 6);
            dgv1.Name = "dgv1";
            dgv1.RowTemplate.Height = 25;
            dgv1.Size = new Size(559, 359);
            dgv1.TabIndex = 1;
            dgv1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(816, 450);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(dgv1);
            tabPage1.Controls.Add(txtmid);
            tabPage1.Controls.Add(orderdate);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(808, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Rent Movies";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(dgv2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(808, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Current Rentals";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgv2
            // 
            dgv2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv2.Location = new Point(21, 6);
            dgv2.Name = "dgv2";
            dgv2.RowTemplate.Height = 25;
            dgv2.Size = new Size(761, 290);
            dgv2.TabIndex = 3;
            // 
            // button3
            // 
            button3.Location = new Point(305, 328);
            button3.Name = "button3";
            button3.Size = new Size(173, 62);
            button3.TabIndex = 4;
            button3.Text = "View";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 450);
            Controls.Add(tabControl1);
            Name = "Form6";
            Text = "Form6";
            ((System.ComponentModel.ISupportInitialize)dgv1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgv1;
        private Button button1;
        private DateTimePicker orderdate;
        private TextBox txtmid;
        private Label label1;
        private Button button2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button button3;
        private DataGridView dgv2;
    }
}