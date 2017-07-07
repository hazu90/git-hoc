using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace HelperLib
{
    public class EmailSender
    {
        public void Send(string subject,string sender ,string body ) 
        {
            var message = new MailMessage();
            message.To.Add(new MailAddress(sender));  // replace with valid value 
            message.From = new MailAddress("hieubv.cntt@gmail.com");  // replace with valid value
            message.Subject = subject;
            message.Body = body;
            message.IsBodyHtml = true;

            using (var smtp = new SmtpClient())
            {
                var credential = new NetworkCredential
                {
                    UserName = "hieubv.cntt@gmail.com",
                    Password = "buiviethieu"
                };
                smtp.Credentials = credential;
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.Send(message);
            }
        }
    }
}
