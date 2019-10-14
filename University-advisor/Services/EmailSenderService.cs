using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using University_advisor.Tools;
using University_advisor.Constants;

namespace University_advisor.Services
{
    public class EmailSenderService
    {
        private static void SendThroughSmtp(MailMessage msg)
        {
            var login = new NetworkCredential(ClientSettings.universityAdvisorMailName, ClientSettings.universityAdvisorMailPassword);
            var client = new SmtpClient(ClientSettings.smtpMailName, 587);
            client.EnableSsl = true;
            client.Credentials = login;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.Send(msg);
        }
        public static void SendEmail(string recipient, string subject, string message)
        {
            try
            {
                var msg = new MailMessage();
                msg.To.Add(new MailAddress(recipient));
                msg.From = new MailAddress(ClientSettings.universityAdvisorMailName);
                msg.Subject = subject;
                msg.Body = message;
                SendThroughSmtp(msg);
                Logger.Log(Messages.sendEmailSuccess);
            }
            catch
            {
                Logger.Log(Messages.sendEmailFailed);
            }
        }
    }
}
