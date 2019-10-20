using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University_advisor.Tools;
using University_advisor.Constants;

namespace University_advisor.Services
{
    class PasswordResetService
    {
        private readonly string username;
        private readonly string email;
        private static Random random = new Random();

        public PasswordResetService(string username, string email)
        {
            this.username = username;
            this.email = email;
        }

        public void Reset()
        {
            var newPassword = GenerateRandomPassword();
            EmailSenderService.SendEmail(email, "UniversityAdvisor password reset",
                                                $"Your new password is: '{newPassword}'." +
                                                Environment.NewLine +
                                                "Change it immediately after first log in.");
            UpdatePassword(newPassword, username);
        }

        private string GenerateRandomPassword()
        {
            const string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(characters, 8).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void UpdatePassword(string newPassword, string username)
        {
            var sqlUpdatePassword = "UPDATE users SET password='" +
                                        Helper.CreateMD5(newPassword) +
                                        "' WHERE username='" + username + "';";
            try
            {
                if (SqlDriver.Execute(sqlUpdatePassword))
                {
                    Logger.Log(Messages.passwordUpdateSuccess);
                }
                else
                {
                    Logger.Log(Messages.passwordUpdateFailed);
                }
            }
            catch (Exception ex)
            {
                Logger.Log(ex.Message);
            }
        }
    }
}
