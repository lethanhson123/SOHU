using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Net.Mail;


namespace SOHU.Services.Implement
{
    public class Mail
    {
        #region Attributes - Properties

        public string MailFrom { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Display { get; set; }
        public string MailTo { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public string SMTPServer { get; set; }
        public int SMTPPort { get; set; }
        public int IsMailUsingSSL { get; set; }
        public int IsMailBodyHtml { get; set; }

        #endregion

        #region Construtors
        public Mail()
        {

        }
        #endregion

        #region Functions

        public static void SendMail(Mail mail)
        {
            System.Net.Mail.MailMessage smail = new System.Net.Mail.MailMessage();
            if (mail.IsMailBodyHtml == 1)
            {
                smail.IsBodyHtml = true;
            }
            else
            {
                smail.IsBodyHtml = false;
            }
            smail.BodyEncoding = System.Text.Encoding.GetEncoding("UTF-8");
            smail.From = new System.Net.Mail.MailAddress(mail.MailFrom, mail.Display);
            foreach (string toMailAddress in mail.MailTo.Split(','))
            {
                if (!string.IsNullOrEmpty(toMailAddress))
                {
                    smail.To.Add(new System.Net.Mail.MailAddress(toMailAddress));
                }
            }
            smail.Subject = mail.Subject;
            smail.Body = mail.Content;
            smail.Priority = MailPriority.High;            
            System.Net.Mail.SmtpClient Client = new System.Net.Mail.SmtpClient();            
            if (mail.IsMailUsingSSL == 1)
            {
                Client.EnableSsl = true;
            }
            else
            {
                Client.EnableSsl = false;
            }
            Client.Host = mail.SMTPServer;
            Client.Port = mail.SMTPPort;
            
            System.Net.NetworkCredential theCredential = new System.Net.NetworkCredential(mail.UserName, mail.Password);
            Client.Credentials = theCredential;
            
            //try
            //{
            Client.Send(smail);
            //}
            //catch
            //{
            //}
        }



        #endregion
    }
}
