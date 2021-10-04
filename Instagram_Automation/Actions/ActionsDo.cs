/*
 * project = InstagramAutomation
 * Author = Lavanya Gollapudi
 * Created Date = 3/10/2021
 */

using Instagram_Automation.page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;
using log4net;
using System;
using OpenQA.Selenium.Support.UI;
using AutoItX3Lib;
using System.Threading;

namespace Instagram_Automation.Actions
{
    public class ActionsDo
    {
        public static Login_page login;
        private static readonly ILog log = LogManager.GetLogger(typeof(Tests));

        public static void AssertAfterLauching(IWebDriver driver)
        {
            string title1 = "Instagram";
            string title = driver.Title;
            Assert.AreEqual(title1, title);
        }

        public static void SignUpOption(IWebDriver driver)
        {
            try
            {
                ExcelOperations.PopulateInCollection(@"C:\Users\lavanya.g\source\repos\Instagram_Automation\Instagram_Automation\TestDataFiles\InstagramRegistration.xlsx");

                SignupPaths signup = new SignupPaths(driver);

                signup.SignupBtn.Click();
                System.Threading.Thread.Sleep(1000);

                Assert.IsTrue(signup.Signupmsg.Displayed);

                signup.Num.SendKeys(ExcelOperations.ReadData(1, "NUMBER"));
                System.Threading.Thread.Sleep(1000);

                signup.FullName.SendKeys(ExcelOperations.ReadData(1, "FULLNAME"));
                System.Threading.Thread.Sleep(1000);

                signup.Username.SendKeys(ExcelOperations.ReadData(1, "USERNAME"));
                System.Threading.Thread.Sleep(1000);

                signup.Password.SendKeys(ExcelOperations.ReadData(1, "PASSWORD"));
                System.Threading.Thread.Sleep(1000);

                signup.SignuptoAcc.Click();
                System.Threading.Thread.Sleep(1000);

                SelectElement element = new SelectElement(signup.Month);
                element.SelectByText("May");
                System.Threading.Thread.Sleep(1000);

                SelectElement element1 = new SelectElement(signup.Date);
                element1.SelectByText("1");
                System.Threading.Thread.Sleep(1000);

                SelectElement element2 = new SelectElement(signup.Year);
                element2.SelectByText("2000");
                System.Threading.Thread.Sleep(1000);

                signup.NextBtn.Click();
                System.Threading.Thread.Sleep(1000);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void LoginToInstagram(IWebDriver driver)
        {
            try
            {
                ExcelOperations.PopulateInCollection(@"C:\Users\lavanya.g\source\repos\Instagram_Automation\Instagram_Automation\TestDataFiles\InstagramLogin.xlsx");
                login = new Login_page(driver);

                login.UN.SendKeys(ExcelOperations.ReadData(1, "Username"));
                System.Threading.Thread.Sleep(1000);

                login.PW.SendKeys(ExcelOperations.ReadData(1, "Password"));
                System.Threading.Thread.Sleep(1000);

                login.loginButton.Click();
                System.Threading.Thread.Sleep(1000);

                log.Info("Loggin Succesfull");
                System.Threading.Thread.Sleep(1000);

                String actualUrl = "https://www.instagram.com/accounts/onetap/?next=%2F";
                String expectedUrl = driver.Url;
                Assert.AreEqual(actualUrl, expectedUrl);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public static void photoUpload(IWebDriver driver)
        {
            try
            {
                ExcelOperations.PopulateInCollection(@"C:\Users\lavanya.g\source\repos\Instagram_Automation\Instagram_Automation\TestDataFiles\InstagramLogin.xlsx");

                ProfilePhoto pic = new ProfilePhoto(driver);

                pic.UN.SendKeys(ExcelOperations.ReadData(1, "Username"));
                System.Threading.Thread.Sleep(1000);

                pic.PW.SendKeys(ExcelOperations.ReadData(1, "Password"));
                System.Threading.Thread.Sleep(1000);

                pic.loginButton.Click();
                System.Threading.Thread.Sleep(1000);

                pic.profileIcon.Click();
                System.Threading.Thread.Sleep(2000);

                pic.ProfileButton.Click();
                System.Threading.Thread.Sleep(2000);

                pic.PhotoUploadIcon.Click();
                System.Threading.Thread.Sleep(2000);

                pic.ChangeProfilePhoto.Click();
                System.Threading.Thread.Sleep(2000);

                pic.UploadPhoto.Click();
                System.Threading.Thread.Sleep(2000);

                AutoItX3 autoit = new AutoItX3();
                autoit.WinActivate("Open");
                autoit.Send(@"C:\Users\lavanya.g\Pictures\Saved Pictures\Flower.jpg");
                Thread.Sleep(3000);
                autoit.Send("{ENTER}");
                Thread.Sleep(5000);

                log.Info("Profile Photo Uploaded Successfully");
                System.Threading.Thread.Sleep(1000);

                var changedprofile = "Profile photo added.";
                Assert.IsTrue(driver.FindElement(By.XPath("//*[@class='gxNyb']")).Text.Contains(changedprofile));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void LogoutOption(IWebDriver driver)
        {
            try
            {
                ExcelOperations.PopulateInCollection(@"C:\Users\lavanya.g\source\repos\Instagram_Automation\Instagram_Automation\TestDataFiles\InstagramLogin.xlsx");

                LogOutPaths outPaths = new LogOutPaths(driver);

                outPaths.UN.SendKeys(ExcelOperations.ReadData(1, "Username"));
                System.Threading.Thread.Sleep(1000);

                outPaths.PW.SendKeys(ExcelOperations.ReadData(1, "Password"));
                System.Threading.Thread.Sleep(1000);

                outPaths.loginButton.Click();
                System.Threading.Thread.Sleep(1000);

                outPaths.profileIcon.Click();
                System.Threading.Thread.Sleep(2000);

                outPaths.LogoutBtn.Click();
                System.Threading.Thread.Sleep(2000);

                Assert.IsTrue(outPaths.loginpage.Displayed);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void InvalidPassword(IWebDriver driver)
        {
            try
            {
                ExcelOperations.PopulateInCollection(@"C:\Users\lavanya.g\source\repos\Instagram_Automation\Instagram_Automation\TestDataFiles\InstagramInvalidPWD.xlsx");
                InvalidData data = new InvalidData(driver);

                data.UN.SendKeys(ExcelOperations.ReadData(1, "Username"));
                System.Threading.Thread.Sleep(1000);

                data.PW.SendKeys(ExcelOperations.ReadData(1, "Password"));
                System.Threading.Thread.Sleep(1000);
                
                data.loginButton.Click();
                System.Threading.Thread.Sleep(1000);

                Assert.IsTrue(data.errormsg.Displayed);

                log.Info("Incorrect Password");
                System.Threading.Thread.Sleep(2000);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
