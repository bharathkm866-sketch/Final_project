using Microsoft.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Final_project
{
    public partial class EmpDet : Form
    {
        public EmpDet()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox8.Text != textBox9.Text)
            {
                MessageBox.Show("password and conform passwor should be same");
            }

            SqlConnection conn = new SqlConnection("Data Source=bharathkm\\SQLEXPRESS;Initial Catalog=registration;Integrated Security=True;Trust Server Certificate=True");
            conn.Open();

            string checkQuery =
    "SELECT COUNT(*) FROM Emp_details WHERE phone = @phone";

            SqlCommand checkCmd = new SqlCommand(checkQuery, conn);

            checkCmd.Parameters.AddWithValue("@phone", textBox2.Text);

            int count = (int)checkCmd.ExecuteScalar();

            if (count > 0)
            {
                MessageBox.Show("Employee already registered");
                return;
            }

           
            string insertQuery = "INSERT INTO Emp_details VALUES (@fname, @phone, @dob, @gender, @country, @qualification, @adress, @city, @email, @password, @conpassword)";
            SqlCommand cmd = new SqlCommand(insertQuery, conn);
            cmd.Parameters.AddWithValue("@fname", textBox1.Text.Trim());
            cmd.Parameters.AddWithValue("@phone", textBox2.Text.Trim());
            cmd.Parameters.AddWithValue("@dob", Convert.ToDateTime(dateTimePicker1.Text));
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@country", comboBox2.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@qualification", textBox3.Text.Trim());
            cmd.Parameters.AddWithValue("@adress", textBox4.Text.ToString());
            cmd.Parameters.AddWithValue("@city", textBox5.Text.Trim());
            cmd.Parameters.AddWithValue("@email", textBox7.Text.Trim());
            cmd.Parameters.AddWithValue("@password", textBox8.Text.Trim());
            cmd.Parameters.AddWithValue("@conpassword", textBox9.Text.Trim());
            cmd.ExecuteNonQuery();
            MessageBox.Show("saved succesfully", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        string gender;

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            gender = "male";
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            gender = "female";
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            gender = "other";
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            Emailid();
        }
        void Emailid()
        {
            if (textBox7.Text.Length > 0)
            {
                Regex regxemail = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");
                if (!regxemail.IsMatch(textBox7.Text.Trim()))
                {

                    MessageBox.Show("Email is not valid", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox7.Focus();
                    return;
                }
            }

        }
    }
}
