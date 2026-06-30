namespace Final_project
{
    partial class AdmMng
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
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.DarkGray;
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(12, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 393);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // button5
            // 
            button5.BackColor = Color.DarkGray;
            button5.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            button5.FlatAppearance.BorderSize = 3;
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 128);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(26, 344);
            button5.Name = "button5";
            button5.Size = new Size(146, 30);
            button5.TabIndex = 5;
            button5.Text = "Logout";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkGray;
            button4.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            button4.FlatAppearance.BorderSize = 3;
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 128);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(26, 270);
            button4.Name = "button4";
            button4.Size = new Size(146, 32);
            button4.TabIndex = 4;
            button4.Text = "view Customer";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkGray;
            button3.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            button3.FlatAppearance.BorderSize = 3;
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 128);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(26, 204);
            button3.Name = "button3";
            button3.Size = new Size(146, 30);
            button3.TabIndex = 3;
            button3.Text = "view Employee";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGray;
            button2.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            button2.FlatAppearance.BorderSize = 3;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 128);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(26, 133);
            button2.Name = "button2";
            button2.Size = new Size(146, 31);
            button2.TabIndex = 2;
            button2.Text = "Add Employee";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGray;
            button1.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            button1.FlatAppearance.BorderSize = 3;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 128);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(26, 55);
            button1.Name = "button1";
            button1.Size = new Size(146, 31);
            button1.TabIndex = 1;
            button1.Text = "Employee Alotment";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.WindowFrame;
            label1.Location = new Point(348, 44);
            label1.Name = "label1";
            label1.Size = new Size(357, 30);
            label1.TabIndex = 1;
            label1.Text = "Welcome To Admin Management";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FloralWhite;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(218, 107);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(705, 101);
            dataGridView1.TabIndex = 4;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(218, 230);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(705, 207);
            dataGridView2.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(218, 84);
            label2.Name = "label2";
            label2.Size = new Size(125, 20);
            label2.TabIndex = 6;
            label2.Text = "Employee Details";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(218, 211);
            label3.Name = "label3";
            label3.Size = new Size(125, 20);
            label3.TabIndex = 7;
            label3.Text = "Employee Details";
            // 
            // AdmMng
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2026_05_23_103643;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(933, 470);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            Name = "AdmMng";
            Text = "AdmMng";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label label2;
        private Label label3;
    }
}