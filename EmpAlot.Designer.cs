namespace Final_project
{
    partial class EmpAlot
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
            dateTimePicker1 = new DateTimePicker();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(385, 203);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 21;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "09:11", "12:02", "02:04" });
            comboBox2.Location = new Point(385, 255);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(200, 23);
            comboBox2.TabIndex = 20;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Chickballapur", "chintamani", "shidalagatta", "goweari bidanooru", "bagepalli" });
            comboBox1.Location = new Point(385, 303);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(200, 23);
            comboBox1.TabIndex = 19;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(385, 134);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 23);
            textBox2.TabIndex = 18;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(385, 83);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label6.Location = new Point(228, 314);
            label6.Name = "label6";
            label6.Size = new Size(39, 17);
            label6.TabIndex = 16;
            label6.Text = "place";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label5.Location = new Point(228, 263);
            label5.Name = "label5";
            label5.Size = new Size(67, 17);
            label5.TabIndex = 15;
            label5.Text = "class time";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label4.Location = new Point(228, 209);
            label4.Name = "label4";
            label4.Size = new Size(67, 17);
            label4.TabIndex = 14;
            label4.Text = "class date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label3.Location = new Point(227, 152);
            label3.Name = "label3";
            label3.Size = new Size(103, 17);
            label3.TabIndex = 13;
            label3.Text = "customer name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label2.Location = new Point(227, 91);
            label2.Name = "label2";
            label2.Size = new Size(105, 17);
            label2.TabIndex = 12;
            label2.Text = "employee name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(349, 44);
            label1.Name = "label1";
            label1.Size = new Size(202, 30);
            label1.TabIndex = 11;
            label1.Text = "Emploee Allotment";
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(377, 340);
            button1.Name = "button1";
            button1.Size = new Size(96, 31);
            button1.TabIndex = 22;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(479, 340);
            button2.Name = "button2";
            button2.Size = new Size(96, 31);
            button2.TabIndex = 23;
            button2.Text = "Submit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(843, 340);
            button3.Name = "button3";
            button3.Size = new Size(112, 31);
            button3.TabIndex = 24;
            button3.Text = "Delete Alotment";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 2;
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(694, 340);
            button4.Name = "button4";
            button4.Size = new Size(96, 31);
            button4.TabIndex = 25;
            button4.Text = "view alotment";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(657, 83);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(345, 243);
            dataGridView1.TabIndex = 26;
            // 
            // EmpAlot
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OliveDrab;
            ClientSize = new Size(1054, 440);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EmpAlot";
            Text = "EmpAlot";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView dataGridView1;
    }
}