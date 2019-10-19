using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_advisor.Constants
{
    public static class Messages
    {
        //Email
        public const string sendEmailSuccess = "Email was successfully sent.";
        public const string sendEmailFailed = "Email could not be sent.";
        public const string emailUpdateSuccess = "Email updated successfully.";
        public const string emailUpdateFailed = "Error changing email.";
        public const string emailsDontMatch = "Emails doesn't match.";
        public const string newEmailSameAsOld = "New email cannot be the same as old one.";
        public const string emailNotSpecified = "Email is not specified";
        public const string badEmailFormat = "Wrong email format";
        //Password
        public const string passwordUpdateSuccess = "Password updated successfully.";
        public const string passwordUpdateFailed = "Error changing password";
        public const string newPasswordSameAsOld = "New password cannot be the same as old one.";
        public const string passwordsDontMatch = "Passwords doesn't match.";
        public const string passwordNotSpecified = "Password is not specified";
        public const string passwordUpdateSuccessInbox = "Password successfully updated. Check your inbox.";
        public const string wrongPasswordOrNoUser = "Wrong password or no user exists";
        public const string passwordsDoNotMatch = "Passwords do not match";
        public const string passwordTooShort = "Password needs to be at least 6 characters long";
        public const string passwordChangeUnsuccessful = "Attempt to change password was unsuccessful";
        //University
        public const string universityUpdateSuccess = "University updated successfully.";
        public const string universityUpdateFailed = "Error changing university";
        public const string newUniversitySameAsOld = "New university cannot be the same as old one.";
        //Status
        public const string statusUpdateSuccess = "Status updated successfully.";
        public const string statusUpdateFailed = "Error changing status.";
        public const string newStatusSameAsOld = "New status cannot be the same as old one.";
        public const string userNotSpecified = "User is not specified";
        //User
        public const string userAttemptedToChangePassword = "User attempted to change password";
        public const string userDontExist = "User with provided information does not exist.";
        public const string userLogInSuccess = "User logged in";
        public const string userLogInFailed = "User could not log in";
        public const string userCreateSuccess = "New user is successfully created";
        public const string userCreateFailed = "User cannot be created";
        public const string emptyFields = "Do not leave empty fields";
        //Database
        public const string dbConnectFailed = "Failed to connect to database. Aborting query";
        public const string queryExecuteSuccess = "Query executed successfully";
        //Logger
        public const string logCreateFailed = "Log file could not be be created";
        //Reviews
        public const string reviewAlreadySubmitted = "Error. You have already submitted this type of review";
    }
}
