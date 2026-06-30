namespace Final_project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            adminLoginToolStripMenuItem = new ToolStripMenuItem();
            employeeLoginToolStripMenuItem = new ToolStripMenuItem();
            cuctomerLoginToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.DarkGreen;
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(961, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adminLoginToolStripMenuItem, employeeLoginToolStripMenuItem, cuctomerLoginToolStripMenuItem });
            menuToolStripMenuItem.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            menuToolStripMenuItem.ForeColor = SystemColors.MenuHighlight;
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(61, 24);
            menuToolStripMenuItem.Text = "Login";
            // 
            // adminLoginToolStripMenuItem
            // 
            adminLoginToolStripMenuItem.Name = "adminLoginToolStripMenuItem";
            adminLoginToolStripMenuItem.Size = new Size(191, 24);
            adminLoginToolStripMenuItem.Text = "Admin Login";
            adminLoginToolStripMenuItem.Click += adminLoginToolStripMenuItem_Click;
            // 
            // employeeLoginToolStripMenuItem
            // 
            employeeLoginToolStripMenuItem.Name = "employeeLoginToolStripMenuItem";
            employeeLoginToolStripMenuItem.Size = new Size(191, 24);
            employeeLoginToolStripMenuItem.Text = "Employee Login";
            employeeLoginToolStripMenuItem.Click += employeeLoginToolStripMenuItem_Click;
            // 
            // cuctomerLoginToolStripMenuItem
            // 
            cuctomerLoginToolStripMenuItem.Name = "cuctomerLoginToolStripMenuItem";
            cuctomerLoginToolStripMenuItem.Size = new Size(191, 24);
            cuctomerLoginToolStripMenuItem.Text = "Customer Login";
            cuctomerLoginToolStripMenuItem.Click += cuctomerLoginToolStripMenuItem_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderColor = Color.Yellow;
            button1.FlatAppearance.BorderSize = 3;
            button1.FlatAppearance.MouseOverBackColor = Color.Navy;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(794, 235);
            button1.Name = "button1";
            button1.Size = new Size(117, 29);
            button1.TabIndex = 1;
            button1.Text = "Register Now";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Screenshot_2026_04_17_124439;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(485, 276);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(218, 266);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(245, 276);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(218, 266);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.Screenshot_2026_04_17_124409;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(12, 276);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(218, 266);
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources.Screenshot_2026_04_17_124548;
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(731, 276);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(218, 266);
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(566, 237);
            label1.Name = "label1";
            label1.Size = new Size(222, 21);
            label1.TabIndex = 6;
            label1.Text = "If you are an new Customer ..!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.IndianRed;
            label2.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(245, 42);
            label2.Name = "label2";
            label2.Size = new Size(612, 30);
            label2.TabIndex = 7;
            label2.Text = "WELLCOME TO ONLINE DRIVING SCHOOL MANAGEMENT ";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // button2
            // 
            button2.Location = new Point(382, 107);
            button2.Name = "button2";
            button2.Size = new Size(81, 31);
            button2.TabIndex = 8;
            button2.Text = "ADM";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(382, 166);
            button3.Name = "button3";
            button3.RightToLeft = RightToLeft.Yes;
            button3.Size = new Size(81, 31);
            button3.TabIndex = 9;
            button3.Text = "EMP";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(382, 233);
            button4.Name = "button4";
            button4.Size = new Size(81, 31);
            button4.TabIndex = 10;
            button4.Text = "CUST";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2026_05_23_100936;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(961, 560);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Home Page";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem adminLoginToolStripMenuItem;
        private ToolStripMenuItem employeeLoginToolStripMenuItem;
        private ToolStripMenuItem cuctomerLoginToolStripMenuItem;
        private Button button1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label1;
        private Label label2;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
