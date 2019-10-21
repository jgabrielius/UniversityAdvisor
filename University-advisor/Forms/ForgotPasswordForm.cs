using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using University_advisor.Services;
using University_advisor.Tools;
using University_advisor.Constants;

namespace University_advisor.Forms
{
    public partial class ForgotPasswordForm : Form
    {
        public ForgotPasswordForm()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void ResetPasswordButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(usernameText.Text))
            {
                MessageBox.Show(Messages.userNotSpecified);
                return;
            }
            if (String.IsNullOrEmpty(emailText.Text))
            {
                MessageBox.Show(Messages.emailNotSpecified);
                return;
            }

            Logger.Log(Messages.userAttemptedToChangePassword);

            if (ValidateFields(usernameText.Text, emailText.Text))
            {
                try
                {
                    new PasswordResetService(usernameText.Text, emailText.Text).Reset();
                    Logger.Log(Messages.passwordUpdateSuccess);
                    MessageBox.Show(Messages.passwordUpdateSuccessInbox);

                    var loginForm = new LoginForm();
                    Hide();
                    loginForm.Show();
                }
                catch
                {
                    Logger.Log(Messages.passwordUpdateFailed);
                    MessageBox.Show(Messages.passwordUpdateFailed);
                }
            }
            else
            {
                Logger.Log(Messages.userDoesNotExist);
                MessageBox.Show(Messages.userDoesNotExist);
            }
        }

        private bool ValidateFields(string username, string email)
        {
            var credentialResult = SqlDriver.Fetch($"SELECT username, email FROM users WHERE username='{username}' AND email='{email}';");
            return (credentialResult != null && credentialResult.Count == 1);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Hide();
            var loginForm = new LoginForm();
            loginForm.Closed += (s, args) => this.Close();
            loginForm.ShowDialog();
        }
    }
}
