
using System.Text.RegularExpressions;

namespace Final_project
{
    public partial class ApplayLL : Form
    {
        public ApplayLL()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (adharnum.Text == "" || Adharname.Text == "" || phnum.Text == "" || emailid.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Please enter required fields", "error");
            }
            else
            {
                MessageBox.Show("Saved succesfully\n Congradulations, Application Submited.\nAfter 6 mounths yuo will get driving licence", "information");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void emailid_Leave(object sender, EventArgs e)
        {
            Emailid();
        }
        void Emailid()
        {
            if (emailid.Text.Length > 0)
            {
                Regex regxemail = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");
                if (!regxemail.IsMatch(emailid.Text.Trim()))
                {

                    MessageBox.Show("Email is not valid", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    emailid.Focus();
                    return;
                }
            }

        }
    }
}