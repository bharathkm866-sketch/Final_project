using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Final_project
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=bharathkm\SQLEXPRESS;Initial Catalog=youtube;Integrated Security=True;Trust Server Certificate=True");

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("enter username and password");
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("enter usrename");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Enter a password");
            }
            else
            {
                string username, user_password;
                username = textBox1.Text;
                user_password = textBox2.Text;

                try
                {
                    string qurry = "SELECT * FROM login_new WHERE username='" + textBox1.Text + "'AND password='" + textBox2.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(qurry, conn);

                    DataTable dtable = new DataTable();
                    sda.Fill(dtable);

                    if (dtable.Rows.Count > 0)
                    {
                        username = textBox1.Text;
                        user_password = textBox2.Text;
                        MessageBox.Show("login succesfully");

                        AdmMng m1 = new AdmMng();
                        m1.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("invalid login details", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox1.Clear();
                        textBox2.Clear();

                        textBox1.Focus();
                    }
                }
                catch
                {
                    MessageBox.Show("error");
                }
                finally
                {
                    conn.Close();
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }
    }
}
