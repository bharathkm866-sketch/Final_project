namespace Final_project
{
    partial class EmpDet
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
            comboBox2 = new ComboBox();
            button2 = new Button();
            button1 = new Button();
            checkBox1 = new CheckBox();
            textBox9 = new TextBox();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            dateTimePicker1 = new DateTimePicker();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox2
            // 
            comboBox2.DisplayMember = "COUNTRY";
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "INDIA", "USA", "AFRICA", "UK" });
            comboBox2.Location = new Point(6, 343);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(167, 23);
            comboBox2.TabIndex = 59;
            // 
            // button2
            // 
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(0, 192, 0);
            button2.Location = new Point(244, 410);
            button2.Name = "button2";
            button2.RightToLeft = RightToLeft.Yes;
            button2.Size = new Size(75, 26);
            button2.TabIndex = 57;
            button2.Text = "Submit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(0, 192, 0);
            button1.Location = new Point(145, 410);
            button1.Name = "button1";
            button1.Size = new Size(75, 26);
            button1.TabIndex = 56;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(367, 368);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(139, 19);
            checkBox1.TabIndex = 55;
            checkBox1.Text = "Remain me password";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(339, 339);
            textBox9.Name = "textBox9";
            textBox9.PasswordChar = '*';
            textBox9.PlaceholderText = "Conforrn password";
            textBox9.Size = new Size(167, 23);
            textBox9.TabIndex = 54;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(339, 280);
            textBox8.Name = "textBox8";
            textBox8.PasswordChar = '*';
            textBox8.PlaceholderText = "Enter Strong password";
            textBox8.Size = new Size(167, 23);
            textBox8.TabIndex = 53;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(339, 218);
            textBox7.Name = "textBox7";
            textBox7.PlaceholderText = "Current Email Addres";
            textBox7.Size = new Size(167, 23);
            textBox7.TabIndex = 52;
            textBox7.Leave += textBox7_Leave;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(339, 147);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "current city";
            textBox5.Size = new Size(167, 23);
            textBox5.TabIndex = 51;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(339, 86);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Current addres";
            textBox4.Size = new Size(167, 23);
            textBox4.TabIndex = 50;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(339, 34);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Enter qualification";
            textBox3.Size = new Size(167, 23);
            textBox3.TabIndex = 49;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(90, 292);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(63, 19);
            radioButton3.TabIndex = 48;
            radioButton3.TabStop = true;
            radioButton3.Text = "Other's";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged_1;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(90, 257);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(63, 19);
            radioButton2.TabIndex = 47;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged_1;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(90, 221);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(51, 19);
            radioButton1.TabIndex = 46;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged_1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(6, 144);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.ShowCheckBox = true;
            dateTimePicker1.Size = new Size(167, 23);
            dateTimePicker1.TabIndex = 45;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(6, 86);
            textBox2.MaxLength = 10;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "10 DIGIT PHONE NUMBER";
            textBox2.Size = new Size(167, 23);
            textBox2.TabIndex = 44;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 34);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter name";
            textBox1.Size = new Size(167, 23);
            textBox1.TabIndex = 43;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(394, 29);
            label1.Name = "label1";
            label1.Size = new Size(124, 21);
            label1.TabIndex = 31;
            label1.Text = "Emplyee details";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox9);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(textBox8);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(textBox7);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Location = new Point(185, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(546, 442);
            groupBox1.TabIndex = 60;
            groupBox1.TabStop = false;
            groupBox1.Text = "||";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.WhiteSmoke;
            label2.Font = new Font("Segoe UI Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 218);
            label2.Name = "label2";
            label2.Size = new Size(49, 17);
            label2.TabIndex = 60;
            label2.Text = "Gender";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.WhiteSmoke;
            label3.Font = new Font("Segoe UI Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(103, 345);
            label3.Name = "label3";
            label3.Size = new Size(52, 17);
            label3.TabIndex = 61;
            label3.Text = "Country";
            // 
            // EmpDet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2026_05_24_111504;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(905, 520);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "EmpDet";
            Text = "EmpDet";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox2;
        private Button button2;
        private Button button1;
        private CheckBox checkBox1;
        private TextBox textBox9;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
    }
}