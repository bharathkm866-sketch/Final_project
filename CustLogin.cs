using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Final_project
{
    public partial class CustLogin : Form
    {
        public CustLogin()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=bharathkm\SQLEXPRESS;Initial Catalog=registration;Integrated Security=True;Trust Server Certificate=True");

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

                    conn.Open();
                    string login = "SELECT * FROM registration WHERE email ='" + textBox1.Text + "' AND password='" + textBox2.Text + "'   ";
                    SqlDataAdapter sqlog = new SqlDataAdapter(login, conn);
                    DataTable dt = new DataTable();
                    sqlog.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        username = textBox1.Text;
                        user_password = textBox2.Text;

                        MessageBox.Show("login successfully");

                        CustMng c1 = new CustMng();
                        c1.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("invalid login details");
                        textBox1.Clear();
                        textBox2.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error in login process" + ex);
                }
                finally
                {
                    conn.Close();
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            Emailid();
        }
        void Emailid()
        {
            if (textBox1.Text.Length > 0)
            {
                Regex regxemail = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");
                if (!regxemail.IsMatch(textBox1.Text.Trim()))
                {

                    MessageBox.Show("Email is not valid", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Focus();
                    return;
                }
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CustReg c1= new CustReg();
            c1.Show();
            this.Hide();
        }
    }
}
