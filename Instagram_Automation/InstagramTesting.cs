/*
 * project = InstagramAutomation
 * Author = Lavanya Gollapudi
 * Created Date = 3/10/2021
 */

using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using AventStack.ExtentReports;

namespace Instagram_Automation
{
    public class Tests : Base.BaseClass
    {
        ExtentReports report = ReportCreation.report();
        ExtentTest test;

        [Test, Order(0)]
        public void SigningUp()
        {
            Actions.ActionsDo.SignUpOption(driver);
        }

        [Test, Order(1)]
        public void LoginToInstagramPage()
        {
            test = report.CreateTest("Tests");
            test.Log(Status.Info, "INSTAGRAMLOGINAUTOMATION");

            Actions.ActionsDo.AssertAfterLauching(driver);

            Actions.ActionsDo.LoginToInstagram(driver);

            TakeScreenshotOfInsta(driver);

            test.Info("InstaScreenshot", MediaEntityBuilder.CreateScreenCaptureFromPath(@"C:\Users\lavanya.g\source\repos\Instagram_Selenium\Instagram_Selenium\Screenshots\.jpg").Build());

            test.Log(Status.Pass, "TestCases Passed");

            report.Flush();
        }

        [Test, Order(2)]
        public void ProfilePhotoUpdate()
        {
            Actions.ActionsDo.photoUpload(driver);
        }

        [Test, Order(3)]
        public void LoggingOut()
        {
            Actions.ActionsDo.LogoutOption(driver);
        }

        [Test,Order(4)]
        public void InvalidCredentials()
        {
            
            Actions.ActionsDo.InvalidPassword(driver);
            TakeScreenshotOfInsta(driver);
        }


        [Test, Order(5)]
        public void Test_SendEmail()
        {
            Gmail.GmailClass.ReadDataFromExcel();
            Gmail.GmailClass.email_send();
        }
    }
}