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
            var login = new NetworkCredential("universityadvisor.lt@gmail.com", "Komanda1");
            var client = new SmtpClient("smtp.gmail.com", 587);
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
                msg.From = new MailAddress("universityadvisor.lt@gmail.com");
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
