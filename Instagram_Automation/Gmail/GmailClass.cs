/*
 * project = InstagramAutomation
 * Author = Lavanya Gollapudi
 * Created Date = 3/10/2021
 */

using System;
using NUnit.Framework;
using System.Net;
using System.Net.Mail;
using Instagram_Automation.page;

namespace Instagram_Automation.Gmail
{
    public class GmailClass : Base.BaseClass
    {
        public static GmailExcelOperations excel;
        //Here we are reading the data from excel
        [SetUp]
        public void LaunchMailPage()
        {
            driver.Url = "https://accounts.google.com/ServiceLogin/identifier?";
        }
        public static void ReadDataFromExcel()
        {
            excel = new GmailExcelOperations();
            excel.PopulateInCollection(@"C:\Users\lavanya.g\source\repos\Instagram_Selenium\Instagram_Selenium\TestDataFiles\GmailLogin.xlsx");
        }

        public static void email_send()
        {
            try
            {
                excel = new GmailExcelOperations();
                MailMessage mail = new MailMessage();
                // Gmail SMTP server address
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                //Sender Email Address
                mail.From = new MailAddress(excel.ReadData(1, "FromMail"));
                //Receiver Email Address  
                mail.To.Add(excel.ReadData(1, "ToMail"));
                //Subject of the mail is added
                mail.Subject = "Instagram test mail";
                //Body of the mail is added
                mail.Body = "mail with Instagram report attachmement";
                Attachment attachment;
                attachment = new Attachment(@"C:\Users\lavanya.g\source\repos\Instagram_Selenium\Instagram_Selenium\Reports\index.html");
                Assert.NotNull(attachment);
                //here we attach the report of the automation
                mail.Attachments.Add(attachment);
                SmtpServer.Port = 587;
                // Gmail user authentication
                SmtpServer.Credentials = new NetworkCredential(excel.ReadData(1, "FromMail"), excel.ReadData(1, "Password"));
                SmtpServer.EnableSsl = true;
                //Here we click send mail
                Console.WriteLine("started to send email...");
                SmtpServer.Send(mail);
                Console.WriteLine("email was sent successfully!");
            }

            catch (Exception e)
            {
                Console.WriteLine("failed to send email with the following error:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
