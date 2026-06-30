namespace Final_project
{
    partial class CustLogin
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
            button3 = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(237, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(449, 267);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatAppearance.BorderColor = Color.Yellow;
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 128);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(283, 194);
            button3.Name = "button3";
            button3.Size = new Size(75, 31);
            button3.TabIndex = 7;
            button3.Text = "Cancel";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(67, 65);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 1;
            label2.Text = "email ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(169, 64);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter email ";
            textBox1.Size = new Size(189, 23);
            textBox1.TabIndex = 3;
            textBox1.Leave += textBox1_Leave;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(169, 118);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.PlaceholderText = "Enter password";
            textBox2.Size = new Size(189, 23);
            textBox2.TabIndex = 8;
            textBox2.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(67, 121);
            label3.Name = "label3";
            label3.Size = new Size(61, 17);
            label3.TabIndex = 2;
            label3.Text = "password";
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderColor = Color.Lime;
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 128);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(169, 194);
            button2.Name = "button2";
            button2.Size = new Size(75, 31);
            button2.TabIndex = 6;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderColor = Color.Red;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatAppearance.MouseOverBackColor = Color.Maroon;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(67, 194);
            button1.Name = "button1";
            button1.Size = new Size(75, 31);
            button1.TabIndex = 5;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(349, 34);
            label1.Name = "label1";
            label1.Size = new Size(182, 30);
            label1.TabIndex = 9;
            label1.Text = "Coustomer Login";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(237, 144);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(121, 15);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "I dont have account..!";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // CustLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "CustLogin";
            Text = "CustLogin";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button button3;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Button button2;
        private Button button1;
        private Label label1;
        private LinkLabel linkLabel1;
    }
}