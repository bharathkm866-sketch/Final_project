namespace Final_project
{
    partial class EmpLogin
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
            label4 = new Label();
            button3 = new Button();
            textBox3 = new TextBox();
            label6 = new Label();
            button2 = new Button();
            label5 = new Label();
            textBox4 = new TextBox();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(195, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(454, 340);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(170, 192);
            label4.Name = "label4";
            label4.Size = new Size(95, 21);
            label4.TabIndex = 15;
            label4.Text = "PASSWORD";
            // 
            // button3
            // 
            button3.FlatAppearance.BorderColor = Color.Yellow;
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatAppearance.MouseOverBackColor = Color.Olive;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(362, 248);
            button3.Name = "button3";
            button3.Size = new Size(75, 30);
            button3.TabIndex = 18;
            button3.Text = "Cancel";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(269, 194);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Enter password";
            textBox3.Size = new Size(168, 23);
            textBox3.TabIndex = 20;
            textBox3.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(192, 0, 0);
            label6.Location = new Point(139, 59);
            label6.Name = "label6";
            label6.Size = new Size(159, 30);
            label6.TabIndex = 13;
            label6.Text = "Employe Login";
            // 
            // button2
            // 
            button2.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 128);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(269, 248);
            button2.Name = "button2";
            button2.Size = new Size(75, 30);
            button2.TabIndex = 17;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(161, 137);
            label5.Name = "label5";
            label5.Size = new Size(102, 20);
            label5.TabIndex = 14;
            label5.Text = "EMPLOYEE ID";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(269, 138);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Enter username";
            textBox4.Size = new Size(168, 23);
            textBox4.TabIndex = 19;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.Red;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(174, 248);
            button1.Name = "button1";
            button1.Size = new Size(75, 30);
            button1.TabIndex = 16;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // EmpLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            BackgroundImage = Properties.Resources.Screenshot_2026_05_23_105803;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            Name = "EmpLogin";
            Text = "EmpLogin";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Button button3;
        private TextBox textBox3;
        private Label label6;
        private Button button2;
        private Label label5;
        private TextBox textBox4;
        private Button button1;
    }
}