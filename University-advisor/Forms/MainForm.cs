using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using University_advisor.Tools;

namespace University_advisor.Forms
{
    public partial class MainForm : Form
    {
        string currentUser;
        public MainForm(string username)
        {
            InitializeComponent();
            currentUser = username;
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            errorMessagePass.Hide();
            errorMessageEmail.Hide();
            errorMessageUniversity.Hide();
            errorMessageStatus.Hide();
            
        }

        private void menuPanel_Paint(object sender, PaintEventArgs e)
        {
                    }

        private void LogoButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(homeTab);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(homeTab);
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(settingsTab);
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(aboutTab);
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(logOutTab);
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(homeTab);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void ChangePassword_Click(object sender, EventArgs e)
        {
            errorMessagePass.Hide();

            string sqlGetCurrentPassword = "SELECT password from userData where username='" + currentUser + "';";
            ArrayList passwordFromDB = SqlDriver.FetchNew(sqlGetCurrentPassword);
            string password = ((Dictionary<string, object>)passwordFromDB[0])["password"].ToString();

            if (currentPassword.Text.Equals(password))
            {
                if (newPassword.Text.Equals(currentPassword.Text))
                {
                    errorMessagePass.Text = "New password cannot be the same as old one.";
                    errorMessagePass.Show();
                }
                if (newPassword.Text.Equals(newPassword2.Text))
                {
                    string sqlUpdatePassword = "UPDATE userData SET password='" + newPassword.Text + "' WHERE username='"+currentUser+"';";
                    try
                    {
                        if (SqlDriver.Execute(sqlUpdatePassword))
                        {
                            errorMessagePass.Text = "Password updated successfully.";
                            Logger.Log("Password updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Error changing password");
                            Logger.Log("Error changing password");
                        }
                    }
                    catch (Exception ex)
                    {
                        Logger.Log(ex.Message);
                    }
                    
                } else
                {
                    errorMessagePass.Text = "Passwords doesn't match.";
                    errorMessagePass.Show();
                }

            }
        }

        private void ChangeEmail_Click(object sender, EventArgs e)
        {
            errorMessageEmail.Hide();

            string sqlGetCurrentEmail = "SELECT email from userData where username='" + currentUser + "';";
            ArrayList emailFromDB = SqlDriver.FetchNew(sqlGetCurrentEmail);
            string email = ((Dictionary<string, object>)emailFromDB[0])["email"].ToString();

            if (currentEmail.Text.Equals(email))
            {
                if (newEmail.Text.Equals(currentEmail.Text))
                {
                    errorMessageEmail.Text = "New email cannot be the same as old one.";
                    errorMessageEmail.Show();
                }
                if (newEmail.Text.Equals(newEmail2.Text))
                {
                    string sqlUpdateEmail = "UPDATE userData SET email='" + newEmail.Text + "' WHERE username='" + currentUser + "';";

                    try
                    {
                        if (SqlDriver.Execute(sqlUpdateEmail))
                        {
                            errorMessagePass.Text = "Email updated successfully.";
                            Logger.Log("Email updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Error changing email");
                            Logger.Log("Error changing email");
                        }
                    }
                    catch (Exception ex)
                    {
                        Logger.Log(ex.Message);
                    }
                }
                else
                {
                    errorMessageEmail.Text = "Emails doesn't match.";
                    errorMessageEmail.Show();
                }
            }
        }

        private void ChangeUniversity_Click(object sender, EventArgs e)
        {
            errorMessageUniversity.Hide();
            if (!universityBox.SelectedItem.Equals("Current university in DB"))
            {
                //Change university in DB
            } else
            {
                errorMessageUniversity.Text = "New university cannot be the same as old one.";
                errorMessageUniversity.Show();
            }
        }

        private void ChangeStatus_Click(object sender, EventArgs e)
        {
            errorMessageStatus.Hide();
            if (!statusBox.SelectedItem.Equals("Current status in DB"))
            {
                //Change status in DB
            }
            else
            {
                errorMessageStatus.Text = "New status cannot be the same as old one.";
                errorMessageStatus.Show();
            }
        }
    }
}
