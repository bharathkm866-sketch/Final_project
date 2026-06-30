namespace Final_project
{
    partial class AddEmp
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
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(395, 217);
            textBox2.MaxLength = 10;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "EX:1234567890";
            textBox2.Size = new Size(185, 23);
            textBox2.TabIndex = 10;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(395, 146);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "EX:13D2026";
            textBox1.Size = new Size(185, 23);
            textBox1.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label3.Location = new Point(247, 220);
            label3.Name = "label3";
            label3.Size = new Size(133, 20);
            label3.TabIndex = 8;
            label3.Text = "Employee Numbe";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label2.Location = new Point(247, 146);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 7;
            label2.Text = "Employee ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Purple;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(331, 71);
            label1.Name = "label1";
            label1.Size = new Size(178, 21);
            label1.TabIndex = 6;
            label1.Text = "Adding New employee";
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            button3.Location = new Point(255, 284);
            button3.Name = "button3";
            button3.Size = new Size(107, 33);
            button3.TabIndex = 13;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            button2.Location = new Point(520, 284);
            button2.Name = "button2";
            button2.Size = new Size(130, 33);
            button2.TabIndex = 12;
            button2.Text = "Delete Employee";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            button1.Location = new Point(376, 284);
            button1.Name = "button1";
            button1.Size = new Size(133, 33);
            button1.TabIndex = 11;
            button1.Text = "Add Employee";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            button4.Location = new Point(670, 284);
            button4.Name = "button4";
            button4.Size = new Size(133, 33);
            button4.TabIndex = 14;
            button4.Text = "View  Employee's";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(586, 113);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 15;
            // 
            // AddEmp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2026_04_17_132321;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(829, 409);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "AddEmp";
            Text = "AddEmp";
            Load += AddEmp_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button4;
        private DataGridView dataGridView1;
    }
}