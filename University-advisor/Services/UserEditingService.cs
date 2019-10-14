using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using University_advisor.Tools;
using University_advisor.Constants;

namespace University_advisor.Services
{
    class UserEditingService
    {
        string currentUser;
        public UserEditingService(string currentUser)
        {
            this.currentUser = currentUser;
        }

        public UserEditingService() { }

        public void ChangePassword(string currentPassword, string newPassword, string newPassword2)
        {
            string sqlGetCurrentPassword = "SELECT password from users where username='" + currentUser + "';";
            ArrayList passwordFromDB = SqlDriver.Fetch(sqlGetCurrentPassword);
            string password = ((Dictionary<string, object>)passwordFromDB[0])["password"].ToString();

            if (Helper.CreateMD5(currentPassword).Equals(password))
            {
                if (newPassword.Equals(currentPassword))
                {
                    MessageBox.Show(Messages.newPasswordSameAsOld);
                    Logger.Log(Messages.newPasswordSameAsOld);
                }
                else if (newPassword.Equals(newPassword2))
                {
                    string sqlUpdatePassword = "UPDATE users SET password='" + Helper.CreateMD5(newPassword) + "' WHERE username='" + currentUser + "';";
                    try
                    {
                        if (SqlDriver.Execute(sqlUpdatePassword))
                        {
                            MessageBox.Show(Messages.passwordUpdateSuccess);
                            Logger.Log(Messages.passwordUpdateSuccess);
                        }
                        else
                        {
                            MessageBox.Show(Messages.passwordUpdateFailed);
                            Logger.Log(Messages.passwordUpdateFailed);
                        }
                    }
                    catch (Exception ex)
                    {
                        Logger.Log(ex.Message);
                    }

                }
                else
                {
                    MessageBox.Show(Messages.passwordsDontMatch);
                    Logger.Log(Messages.passwordsDontMatch);
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
                    MessageBox.Show(Messages.newEmailSameAsOld);
                    Logger.Log(Messages.newEmailSameAsOld);

                }
                else if (newEmail.Equals(newEmail2))
                {
                    string sqlUpdateEmail = "UPDATE users SET email='" + newEmail + "' WHERE username='" + currentUser + "';";

                    try
                    {
                        if (SqlDriver.Execute(sqlUpdateEmail))
                        {
                            MessageBox.Show(Messages.emailUpdateSuccess);
                            Logger.Log(Messages.emailUpdateSuccess);
                        }
                        else
                        {
                            MessageBox.Show(Messages.emailUpdateFailed);
                            Logger.Log(Messages.emailUpdateFailed);
                        }
                    }
                    catch (Exception ex)
                    {
                        Logger.Log(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show(Messages.emailsDontMatch);
                    Logger.Log(Messages.emailsDontMatch);

                }
            }

        }

        public void ChangeUniversity(string selectedUniversity)
        {
            if (!selectedUniversity.Equals(GetCurrentUniversity()))
            {
                string sqlGetNewUniversityID = "select universityid from universities where name ='" + selectedUniversity + "';";
                ArrayList newUniversityIdFromDB = SqlDriver.Fetch(sqlGetNewUniversityID);
                string newUniversityId = ((Dictionary<string, object>)newUniversityIdFromDB[0])["universityId"].ToString();

                string sqlUpdateUniversityID = "update users set universityid =" + newUniversityId + " where username ='" + currentUser + "';";
                try
                {
                    if (SqlDriver.Execute(sqlUpdateUniversityID))
                    {
                        MessageBox.Show(Messages.universityUpdateSuccess);
                        Logger.Log(Messages.universityUpdateSuccess);
                    }
                    else
                    {
                        MessageBox.Show(Messages.universityUpdateFailed);
                        Logger.Log(Messages.universityUpdateFailed);
                    }
                }
                catch (Exception ex)
                {
                    Logger.Log(ex.Message);
                }

            }
            else
            {
                MessageBox.Show(Messages.newUniversitySameAsOld);
                Logger.Log(Messages.newUniversitySameAsOld);
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
                        MessageBox.Show(Messages.statusUpdateSuccess);
                        Logger.Log(Messages.statusUpdateSuccess);
                    }
                    else
                    {
                        MessageBox.Show(Messages.statusUpdateFailed);
                        Logger.Log(Messages.statusUpdateFailed);
                    }
                }
                catch (Exception ex)
                {
                    Logger.Log(ex.Message);
                }
            }
            else
            {
                Logger.Log(Messages.newStatusSameAsOld);
            }
        }

        public string GetCurrentUniversity()
        {
            string sqlGetCurrentUniversity = "select universities.name from universities, users where universities.universityId = users.universityid and users.username = '" + currentUser + "';";
            ArrayList universityIdFromDB = SqlDriver.Fetch(sqlGetCurrentUniversity);
            return ((Dictionary<string, object>)universityIdFromDB[0])["name"].ToString();
        }

        public string GetCurrentStatus()
        {
            string sqlGetCurrentStatus = "select status from users where username = '" + currentUser + "';";
            ArrayList statusFromDB = SqlDriver.Fetch(sqlGetCurrentStatus);
            return ((Dictionary<string, object>)statusFromDB[0])["status"].ToString();
        }

        public List<String> GetAllUniversities()
        {
            var universityResult = SqlDriver.Fetch("SELECT name FROM universities");
            var universityList = new List<string>();
            if (universityResult.Count != 0)
            {
                foreach (Dictionary<string, object> row in universityResult)
                {
                    universityList.Add(row["name"].ToString());
                }
            }
            return universityList;
        } 

        public List<String> GetUserInfo()
        {
            var sqlUserInfo = SqlDriver.Fetch("select email, first_name, last_name, universities.name, status from universities, users where users.universityid = universities.universityId and username = '" + currentUser + "';");
            var userInfo = new List<string>();

            userInfo.Add(((Dictionary<string, object>)sqlUserInfo[0])["email"].ToString());
            userInfo.Add(((Dictionary<string, object>)sqlUserInfo[0])["first_name"].ToString());
            userInfo.Add(((Dictionary<string, object>)sqlUserInfo[0])["last_name"].ToString());
            userInfo.Add(((Dictionary<string, object>)sqlUserInfo[0])["name"].ToString());
            userInfo.Add(((Dictionary<string, object>)sqlUserInfo[0])["status"].ToString());
            return userInfo;
        }

    }
}
