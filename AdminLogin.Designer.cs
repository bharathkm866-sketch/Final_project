namespace Final_project
{
    partial class AdminLogin
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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1 = new Panel();
            label1 = new Label();
            groupBox1 = new GroupBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ControlLightLight;
            textBox2.Location = new Point(195, 140);
            textBox2.MaxLength = 20;
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.PlaceholderText = "Enter Password ";
            textBox2.Size = new Size(200, 23);
            textBox2.TabIndex = 18;
            // 
            // textBox1
            // 
            textBox1.ForeColor = SystemColors.WindowText;
            textBox1.Location = new Point(195, 95);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter Admin Id";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(108, 143);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 16;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(108, 95);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 15;
            label2.Text = "User Id";
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatAppearance.BorderColor = Color.Yellow;
            button3.FlatAppearance.MouseOverBackColor = Color.DarkKhaki;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            button3.ForeColor = SystemColors.MenuHighlight;
            button3.Location = new Point(297, 199);
            button3.Name = "button3";
            button3.Size = new Size(98, 31);
            button3.TabIndex = 21;
            button3.Text = "Clean";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderColor = Color.ForestGreen;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 128);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            button2.ForeColor = SystemColors.MenuHighlight;
            button2.Location = new Point(195, 199);
            button2.Name = "button2";
            button2.Size = new Size(96, 31);
            button2.TabIndex = 20;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderColor = Color.Red;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            button1.ForeColor = SystemColors.MenuHighlight;
            button1.Location = new Point(98, 199);
            button1.Name = "button1";
            button1.Size = new Size(91, 31);
            button1.TabIndex = 19;
            button1.Text = "exit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.PowderBlue;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-96, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 37);
            panel1.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(384, 7);
            label1.Name = "label1";
            label1.Size = new Size(142, 25);
            label1.TabIndex = 0;
            label1.Text = "ADMIN LOGIN";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(185, 96);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(512, 308);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Admin";
            // 
            // AdminLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2026_05_23_103237;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "AdminLogin";
            Text = "AdminLogin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
    }
}