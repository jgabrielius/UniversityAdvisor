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
        ArrayList statusList = new ArrayList() { "Student", "Graduate", "Lecturer" };

        public MainForm(string username)
        {
            InitializeComponent();
            CenterToScreen();
            SetValues();
            currentUser = username;
            tabsController.Appearance = TabAppearance.FlatButtons;
            tabsController.ItemSize = new Size(0, 1);
            tabsController.SizeMode = TabSizeMode.Fixed;
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
            tabsController.SelectTab(homeTab);
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            tabsController.SelectTab(homeTab);
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            tabsController.SelectTab(settingsTab);
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            tabsController.SelectTab(aboutTab);
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            tabsController.SelectTab(logOutTab);
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            tabsController.SelectTab(homeTab);
        }

        private void ChangePassword_Click(object sender, EventArgs e)
        {
            errorMessagePass.Hide();

            string sqlGetCurrentPassword = "SELECT password from users where username='" + currentUser + "';";
            ArrayList passwordFromDB = SqlDriver.Fetch(sqlGetCurrentPassword);
            string password = ((Dictionary<string, object>)passwordFromDB[0])["password"].ToString();

            if (Helper.CreateMD5(currentPassword.Text).Equals(password))
            {
                if (newPassword.Text.Equals(currentPassword.Text))
                {
                    errorMessagePass.Text = "New password cannot be the same as old one.";
                    errorMessagePass.Show();
                    Logger.Log("New password cannot be the same as old one.");
                }
                else if (newPassword.Text.Equals(newPassword2.Text))
                {
                    string sqlUpdatePassword = "UPDATE users SET password='" + Helper.CreateMD5(newPassword.Text) + "' WHERE username='"+currentUser+"';";
                    try
                    {
                        if (SqlDriver.Execute(sqlUpdatePassword))
                        {
                            errorMessagePass.Text = "Password updated successfully.";
                            errorMessagePass.Show();
                            Logger.Log("Password updated successfully.");
                        }
                        else
                        {
                            errorMessagePass.Text = "Error changing password";
                            errorMessagePass.Show();
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
                    Logger.Log("Passwords doesn't match.");
                }

            }
        }

        private void ChangeEmail_Click(object sender, EventArgs e)
        {
            errorMessageEmail.Hide();

            string sqlGetCurrentEmail = "SELECT email from users where username='" + currentUser + "';";
            ArrayList emailFromDB = SqlDriver.Fetch(sqlGetCurrentEmail);
            string email = ((Dictionary<string, object>)emailFromDB[0])["email"].ToString();

            if (currentEmail.Text.Equals(email))
            {
                if (newEmail.Text.Equals(currentEmail.Text))
                {
                    errorMessageEmail.Text = "New email cannot be the same as old one.";
                    errorMessageEmail.Show();
                    Logger.Log("New email cannot be the same as old one.");

                }
                else if (newEmail.Text.Equals(newEmail2.Text))
                {
                    string sqlUpdateEmail = "UPDATE users SET email='" + newEmail.Text + "' WHERE username='" + currentUser + "';";

                    try
                    {
                        if (SqlDriver.Execute(sqlUpdateEmail))
                        {
                            errorMessageEmail.Text = "Email updated successfully.";
                            errorMessageEmail.Show();
                            Logger.Log("Email updated successfully.");
                        }
                        else
                        {
                            errorMessageEmail.Text = "Error changing email.";
                            errorMessageEmail.Show();
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
                    Logger.Log("Emails doesn't match.");

                }
            }
        }

        private void ChangeUniversity_Click(object sender, EventArgs e)
        {
            errorMessageUniversity.Hide();
            string sqlGetCurrentUniversity = "select universities.name from universities, users where universities.universityId = users.universityid and users.username = '" + currentUser + "';";
            ArrayList universityIdFromDB = SqlDriver.Fetch(sqlGetCurrentUniversity);
            string currentUniversity = ((Dictionary<string, object>)universityIdFromDB[0])["name"].ToString();

            if (!universityBox.SelectedItem.Equals(currentUniversity))
            {
                string sqlGetNewUniversityID = "select universityid from universities where name ='" + universityBox.SelectedItem+"';";
                ArrayList newUniversityIdFromDB = SqlDriver.Fetch(sqlGetNewUniversityID);
                string newUniversityId = ((Dictionary<string, object>)newUniversityIdFromDB[0])["universityId"].ToString();

                string sqlUpdateUniversityID = "update users set universityid =" + newUniversityId + " where username ='" + currentUser + "';";
                try
                {
                    if (SqlDriver.Execute(sqlUpdateUniversityID))
                    {
                        MessageBox.Show("University updated successfully.");
                        Logger.Log("University updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Error changing university");
                        Logger.Log("Error changing university");
                    }
                }
                catch (Exception ex)
                {
                    Logger.Log(ex.Message);
                }

            }
            else
            {
                errorMessageUniversity.Text = "New university cannot be the same as old one.";
                errorMessageUniversity.Show();
                Logger.Log("New university cannot be the same as old one.");
            }
        }

        private void ChangeStatus_Click(object sender, EventArgs e)
        {
            errorMessageStatus.Hide();

            string sqlGetCurrentStatus = "SELECT status from users where username='" + currentUser + "';";
            ArrayList statusFromDB = SqlDriver.Fetch(sqlGetCurrentStatus);
            string currentStatus = ((Dictionary<string, object>)statusFromDB[0])["status"].ToString();

            if (!statusBox.SelectedItem.Equals(currentStatus))
            {
                string sqlUpdateStatus = "UPDATE users SET status='" + statusBox.SelectedItem + "' WHERE username='" + currentUser + "';";

                try
                {
                    if (SqlDriver.Execute(sqlUpdateStatus))
                    {
                        MessageBox.Show("Status updated successfully.");
                        Logger.Log("Status updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Error changing status.");
                        Logger.Log("Error changing status");
                    }
                }
                catch (Exception ex)
                {
                    Logger.Log(ex.Message);
                }
            }
            else
            {
                Logger.Log("New status cannot be the same as old one.");
            }
        }

        private void SetValues()
        {
            var universityResult = SqlDriver.Fetch("SELECT name FROM universities");
            if (universityResult.Count != 0)
            {
                var universityList = new List<string>();
                foreach (Dictionary<string, object> row in universityResult)
                {
                    universityList.Add(row["name"].ToString());
                }
                universityBox.DataSource = universityList;
                statusBox.DataSource = statusList;
            }
        }
    }
}
