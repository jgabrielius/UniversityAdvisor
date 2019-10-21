using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using University_advisor.Tools;
using University_advisor.Constants;
using System.Text.RegularExpressions;

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

        public void UpdateSetting(string setting, string currentInputSetting, string newInputSetting,
            string newInputSetting2, string messageSameAsOld, string messageSuccess, string messageFail,
            string messageDontMatch, string incorrectCurrentSetting)
        {
            if (currentInputSetting.Equals(GetCurrentSetting(setting)))
            {
                if (newInputSetting.Equals(GetCurrentSetting(setting)))
                {
                    MessageBox.Show(messageSameAsOld);
                    Logger.Log(messageSameAsOld);
                }
                else if (newInputSetting.Equals(newInputSetting2))
                {
                    var sqlUpdate = "UPDATE users SET " + setting + " ='" + newInputSetting + "' WHERE username='" + currentUser + "';";
                    try
                    {
                        if (SqlDriver.Execute(sqlUpdate))
                        {
                            MessageBox.Show(messageSuccess);
                            Logger.Log(messageSuccess);
                        }
                        else
                        {
                            MessageBox.Show(messageFail);
                            Logger.Log(messageFail);
                        }
                    }
                    catch (Exception ex)
                    {
                        Logger.Log(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show(messageDontMatch);
                    Logger.Log(messageDontMatch);
                }
            }
            else
            {
                MessageBox.Show(incorrectCurrentSetting);
                Logger.Log(incorrectCurrentSetting);
            }
        }

        public void ChangeUniversity(string selectedUniversity)
        {
            if (!selectedUniversity.Equals(GetCurrentUniversity()))
            {
                var sqlGetNewUniversityID = "select universityid from universities where name ='" + selectedUniversity + "';";
                var newUniversityIdFromDB = SqlDriver.Fetch(sqlGetNewUniversityID);
                var newUniversityId = ((Dictionary<string, object>)newUniversityIdFromDB[0])["universityId"].ToString();
                var sqlUpdateUniversityID = "update users set universityid =" + newUniversityId + " where username ='" + currentUser + "';";

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
            if (!selectedStatus.Equals(GetCurrentSetting("status")))
            {
                var sqlUpdateStatus = "UPDATE users SET status='" + selectedStatus + "' WHERE username='" + currentUser + "';";

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

        public string GetCurrentSetting(string setting)
        {
            var settingFromDB = SqlDriver.Fetch("SELECT " + setting + " from users where username='" + currentUser + "';");
            return ((Dictionary<string, object>)settingFromDB[0])[setting].ToString();
        }

        public string GetCurrentUniversity()
        {
            var universityIdFromDB = SqlDriver.Fetch("select universities.name from universities, users where universities.universityId = users.universityid and users.username = '" + currentUser + "';");
            return ((Dictionary<string, object>)universityIdFromDB[0])["name"].ToString();
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

        public bool CheckEmailFormat(string email)
        {
            var regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (regex.Match(email).Success)
            {
                return true;
            }
            else
            {
                MessageBox.Show(Messages.badEmailFormat);
                Logger.Log(Messages.badEmailFormat);
                return false;
            }
        }
    }
}
