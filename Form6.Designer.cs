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
            panel1 = new Panel();
            button2 = new Button();
            orderdate = new DateTimePicker();
            txtmid = new TextBox();
            label1 = new Label();
            button1 = new Button();
            dgv1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(orderdate);
            panel1.Controls.Add(txtmid);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 450);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(57, 198);
            button2.Name = "button2";
            button2.Size = new Size(75, 42);
            button2.TabIndex = 4;
            button2.Text = "Order!";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // orderdate
            // 
            orderdate.Location = new Point(12, 143);
            orderdate.Name = "orderdate";
            orderdate.Size = new Size(176, 23);
            orderdate.TabIndex = 3;
            // 
            // txtmid
            // 
            txtmid.Location = new Point(47, 113);
            txtmid.Name = "txtmid";
            txtmid.Size = new Size(99, 23);
            txtmid.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 92);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 1;
            label1.Text = "M_Id:";
            // 
            // button1
            // 
            button1.Location = new Point(57, 30);
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
            dgv1.Dock = DockStyle.Top;
            dgv1.Location = new Point(200, 0);
            dgv1.Name = "dgv1";
            dgv1.RowTemplate.Height = 25;
            dgv1.Size = new Size(600, 450);
            dgv1.TabIndex = 1;
            dgv1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgv1);
            Controls.Add(panel1);
            Name = "Form6";
            Text = "Form6";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgv1;
        private Button button1;
        private DateTimePicker orderdate;
        private TextBox txtmid;
        private Label label1;
        private Button button2;
    }
}