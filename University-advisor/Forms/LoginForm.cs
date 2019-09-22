using System;
using System.Collections.Generic;
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
            if (String.IsNullOrEmpty(usernameTextBox.Text))
            {
                MessageBox.Show("User is not specified");
                return;
            }
            if (String.IsNullOrEmpty(passwordTextBox.Text))
            {
                MessageBox.Show("Password is not specified");
                return;
            }

            if (ValidateFields(usernameTextBox.Text, passwordTextBox.Text))
            {
                Logger.Log("User logged in");
                var mainForm = new MainForm();
                Hide();
                mainForm.Show();
            }
            else
            {
                Logger.Log("User could not log in");
                MessageBox.Show("Wrong password or no user exists");
            }
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            var signupForm = new SignupForm();

            Hide();
            signupForm.Show();
        }

        private bool ValidateFields(string username, string password)
        {
            var credentialResult = SqlDriver.Fetch("SELECT username, password FROM userData");
            if (credentialResult.Count != 0)
            {
                var credentials = new List<string>();
                foreach (Object[] row in credentialResult)
                {
                    foreach (object column in row)
                    {
                        credentials.Add(column.ToString());
                    }
                }
                if (username.Equals(credentials[0]) && password.Equals(credentials[1]))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}
