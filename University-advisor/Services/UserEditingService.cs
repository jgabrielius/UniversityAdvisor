using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using University_advisor.Tools;

namespace University_advisor.Services
{
    class UserEditingService
    {
        string currentUser;
        public UserEditingService(string currentUser)
        {
            this.currentUser = currentUser;
        }

        public void ChangePassword(string currentPassword, string newPassword, string newPassword2)
        {
            string sqlGetCurrentPassword = "SELECT password from users where username='" + currentUser + "';";
            ArrayList passwordFromDB = SqlDriver.Fetch(sqlGetCurrentPassword);
            string password = ((Dictionary<string, object>)passwordFromDB[0])["password"].ToString();

            if (Helper.CreateMD5(currentPassword).Equals(password))
            {
                if (newPassword.Equals(currentPassword))
                {
                    MessageBox.Show("New password cannot be the same as old one.");
                    Logger.Log("New password cannot be the same as old one.");
                }
                else if (newPassword.Equals(newPassword2))
                {
                    string sqlUpdatePassword = "UPDATE users SET password='" + Helper.CreateMD5(newPassword) + "' WHERE username='" + currentUser + "';";
                    try
                    {
                        if (SqlDriver.Execute(sqlUpdatePassword))
                        {
                            MessageBox.Show("Password updated successfully.");
                            Logger.Log("Password updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Error changing password.");
                            Logger.Log("Error changing password.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Logger.Log(ex.Message);
                    }

                }
                else
                {
                    MessageBox.Show("Passwords doesn't match.");
                    Logger.Log("Passwords doesn't match.");
                }

            }
        }

        public void ChangeEmail(string currentEmail, string newEmail, string newEmail2)
        {
            string sqlGetCurrentEmail = "SELECT email from users where username='" + currentUser + "';";
            ArrayList emailFromDB = SqlDriver.Fetch(sqlGetCurrentEmail);
            string email = ((Dictionary<string, object>)emailFromDB[0])["email"].ToString();

            if (currentEmail.Equals(email))
            {
                if (newEmail.Equals(currentEmail))
                {
                    MessageBox.Show("New email cannot be the same as old one.");
                    Logger.Log("New email cannot be the same as old one.");

                }
                else if (newEmail.Equals(newEmail2))
                {
                    string sqlUpdateEmail = "UPDATE users SET email='" + newEmail + "' WHERE username='" + currentUser + "';";

                    try
                    {
                        if (SqlDriver.Execute(sqlUpdateEmail))
                        {
                            MessageBox.Show("Email updated successfully.");
                            Logger.Log("Email updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Error changing email.");
                            Logger.Log("Error changing email.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Logger.Log(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Emails doesn't match.");
                    Logger.Log("Emails doesn't match.");

                }
            }

        }

        public void ChangeUniversity(string selectedUniversity)
        {
            string sqlGetCurrentUniversity = "select universities.name from universities, users where universities.universityId = users.universityid and users.username = '" + currentUser + "';";
            ArrayList universityIdFromDB = SqlDriver.Fetch(sqlGetCurrentUniversity);
            string currentUniversity = ((Dictionary<string, object>)universityIdFromDB[0])["name"].ToString();

            if (!selectedUniversity.Equals(currentUniversity))
            {
                string sqlGetNewUniversityID = "select universityid from universities where name ='" + selectedUniversity + "';";
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
                MessageBox.Show("New university cannot be the same as old one.");
                Logger.Log("New university cannot be the same as old one.");
            }
        }

        public void ChangeStatus(string selectedStatus)
        {
            string sqlGetCurrentStatus = "SELECT status from users where username='" + currentUser + "';";
            ArrayList statusFromDB = SqlDriver.Fetch(sqlGetCurrentStatus);
            string currentStatus = ((Dictionary<string, object>)statusFromDB[0])["status"].ToString();

            if (!selectedStatus.Equals(currentStatus))
            {
                string sqlUpdateStatus = "UPDATE users SET status='" + selectedStatus + "' WHERE username='" + currentUser + "';";

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



    }
}
