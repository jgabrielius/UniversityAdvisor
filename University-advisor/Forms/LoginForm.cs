using System;
using System.Windows.Forms;
using University_advisor.Tools;

namespace University_advisor.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "")
            {
                MessageBox.Show("User is not specified");
                return;
            }
            if (passwordTextBox.Text == "")
            {
                MessageBox.Show("Password is not specified");
                return;
            }

            Logger.Log("Logged in");
            // Validate username and password here by sending request to DB to check if user exists.
            var mainForm = new MainForm();

            Hide();
            mainForm.Show();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            var signupForm = new SignupForm();

            Hide();
            signupForm.Show();
        }
    }
}
