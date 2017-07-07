using HelperLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Business
{
    public class MailConfirmAccountBAL
    {
        public bool SendConfirmMail(string sender, string username,string token)
        {
            var emailSender = new EmailSender();
            var subject = "Please validate your email address to access - FFoody.vn";
            var body = "Hello ";
            body += "<br/>";
            body += "<br/>";
            body += "Thank you for registering Foody.vn . . In order to start, please activate your account by clicking the following URL:";
            body += "<a href=\"http://ffoodyvn.com:8088/Account/Activate?username=" + username + "&token=" + token + "\">http://ffoodyvn.com:8088/Account/Activate?username=" + username + "&token=" + token + "</a>";
            body += "Please validate this email address in the next 7 days to use the service. You only need to do this once. <br/>";
            body += "Regards,";
            emailSender.Send(subject, sender, body);
            return true;
        }
    }
}

