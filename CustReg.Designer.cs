namespace Final_project
{
    partial class CustReg
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
            groupBox1 = new GroupBox();
            label10 = new Label();
            textBox8 = new TextBox();
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            comboBox1 = new ComboBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Red;
            groupBox1.BackgroundImage = Properties.Resources.Screenshot_2026_04_17_1323211;
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(textBox8);
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox7);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(47, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(720, 507);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = ":::";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Location = new Point(418, 299);
            label10.Name = "label10";
            label10.Size = new Size(102, 15);
            label10.TabIndex = 39;
            label10.Text = " alternative Phone";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(423, 317);
            textBox8.Name = "textBox8";
            textBox8.PlaceholderText = "Enter alternative number";
            textBox8.Size = new Size(252, 23);
            textBox8.TabIndex = 38;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Transparent;
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Location = new Point(553, 484);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.RightToLeft = RightToLeft.Yes;
            linkLabel1.Size = new Size(136, 15);
            linkLabel1.TabIndex = 37;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Already I have account..!";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 255);
            button1.FlatAppearance.MouseOverBackColor = Color.Yellow;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(82, 447);
            button1.Name = "button1";
            button1.Size = new Size(177, 34);
            button1.TabIndex = 36;
            button1.Text = "Register Now";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Male", "Female", "Other's" });
            comboBox1.Location = new Point(423, 233);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(252, 23);
            comboBox1.TabIndex = 35;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(424, 458);
            textBox7.Name = "textBox7";
            textBox7.PlaceholderText = "Enter password";
            textBox7.Size = new Size(252, 23);
            textBox7.TabIndex = 34;
            textBox7.UseSystemPasswordChar = true;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(42, 396);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Enter Username";
            textBox6.Size = new Size(252, 23);
            textBox6.TabIndex = 33;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(42, 317);
            textBox5.MaxLength = 10;
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Enter 10 Digit number";
            textBox5.Size = new Size(252, 23);
            textBox5.TabIndex = 32;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(424, 396);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Enter Email";
            textBox4.Size = new Size(252, 23);
            textBox4.TabIndex = 31;
            textBox4.Leave += textBox4_Leave;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(42, 241);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Current adress";
            textBox3.Size = new Size(252, 23);
            textBox3.TabIndex = 30;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(423, 147);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Enter lastname";
            textBox2.Size = new Size(252, 23);
            textBox2.TabIndex = 29;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.WhiteSmoke;
            textBox1.Location = new Point(42, 155);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter firstname";
            textBox1.Size = new Size(252, 23);
            textBox1.TabIndex = 28;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Location = new Point(424, 440);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 27;
            label9.Text = "Password";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Location = new Point(42, 299);
            label8.Name = "label8";
            label8.Size = new Size(41, 15);
            label8.TabIndex = 26;
            label8.Text = "Phone";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Location = new Point(423, 215);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 25;
            label7.Text = "Gender";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(423, 129);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 24;
            label6.Text = "Lastname";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(42, 378);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 23;
            label5.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(423, 378);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 22;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(42, 223);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 21;
            label3.Text = "Address";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(42, 135);
            label2.Name = "label2";
            label2.Size = new Size(68, 17);
            label2.TabIndex = 20;
            label2.Text = "Firstname";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(243, 41);
            label1.Name = "label1";
            label1.Size = new Size(263, 30);
            label1.TabIndex = 19;
            label1.Text = "Create Customer Account";
            // 
            // CustReg
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(811, 551);
            Controls.Add(groupBox1);
            Name = "CustReg";
            Text = "Customer Registration";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox comboBox1;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private LinkLabel linkLabel1;
        private Label label10;
        private TextBox textBox8;
    }
}