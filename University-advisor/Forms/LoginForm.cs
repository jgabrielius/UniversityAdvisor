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
            CenterToScreen();
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
                Hide();
                var mainForm = new MainForm(usernameTextBox.Text);
                mainForm.Closed += (s, args) => this.Close();
                mainForm.ShowDialog();
            }
            else
            {
                Logger.Log("User could not log in");
                MessageBox.Show("Wrong password or no user exists");
            }
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            Hide();
            var signupForm = new SignupForm();
            signupForm.Closed += (s, args) => this.Close();
            signupForm.ShowDialog();
        }

        private bool ValidateFields(string username, string password)
        {
            string hashedPassword = Helper.CreateMD5(password);
            var credentialResult = SqlDriver.Fetch($"SELECT username, password FROM users WHERE username='{username}' AND password='{hashedPassword}';");
            return (credentialResult != null && credentialResult.Count == 1);
        }

        private void ForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            var forgotPasswordForm = new ForgotPasswordForm();
            forgotPasswordForm.Closed += (s, args) => this.Close();
            forgotPasswordForm.ShowDialog();
        }
    }
}
