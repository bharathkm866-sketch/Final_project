using Microsoft.Data.SqlClient;
using System.Drawing.Text;
using System.Text.RegularExpressions;

namespace Final_project
{
    public partial class CustReg : Form
    {
        public CustReg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Enter required values");
            }
            else
            { 
                SqlConnection conn = new SqlConnection("Data Source=bharathkm\\SQLEXPRESS;Initial Catalog=registration;Integrated Security=True;Trust Server Certificate=True");
                conn.Open();

                string checkQuery =
        "SELECT COUNT(*) FROM registration WHERE phone = @phone";

                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);

                checkCmd.Parameters.AddWithValue("@phone", textBox5.Text);

                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Customer  already registered");
                    return;
                }

                string insertQuery = "INSERT INTO registration VALUES (@firstname, @lastname, @address, @gender, @email, @phone, @alter_num, @username,@password)";
                SqlCommand cmd = new SqlCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@firstname", textBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@lastname", textBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@address", textBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@gender", comboBox1.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@email", textBox4.Text.ToString());
                cmd.Parameters.AddWithValue("@phone", textBox5.Text.Trim());
                cmd.Parameters.AddWithValue("@alter_num", textBox8.Text.Trim());
                cmd.Parameters.AddWithValue("@username", textBox6.Text.Trim());
                cmd.Parameters.AddWithValue("@password", textBox7.Text.Trim());
                cmd.ExecuteNonQuery();
                MessageBox.Show("registraction succesfully", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CustLogin e1 = new CustLogin();
                e1.Show();
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            Emailid();
        }
        void Emailid()
        {
            if (textBox4.Text.Length > 0)
            {
                Regex regxemail = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");
                if (!regxemail.IsMatch(textBox4.Text.Trim()))
                {

                    MessageBox.Show("Email is not valid", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox4.Focus();
                    return;
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {




        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CustLogin c1= new CustLogin();
            c1.Show();
            this.Close();
        }
    }

}
        




