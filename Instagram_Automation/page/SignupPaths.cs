/*
 * project = InstagramAutomation
 * Author = Lavanya Gollapudi
 * Created Date = 3/10/2021
 */

using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Instagram_Automation.page
{
    public class SignupPaths
    {
        public static IWebDriver driver;
        public SignupPaths(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Sign up')]")]
        [CacheLookup]
        public IWebElement SignupBtn;

        [FindsBy(How = How.XPath, Using = "//*[@class='vvzhL ']")]
        [CacheLookup]
        public IWebElement Signupmsg;

        [FindsBy(How = How.Name, Using = "emailOrPhone")]
        [CacheLookup]
        public IWebElement Num;

        [FindsBy(How = How.Name, Using = "fullName")]
        [CacheLookup]
        public IWebElement FullName;

        [FindsBy(How = How.Name, Using = "username")]
        [CacheLookup]
        public IWebElement Username;

        [FindsBy(How = How.Name, Using = "password")]
        [CacheLookup]
        public IWebElement Password;

        [FindsBy(How = How.XPath, Using = "//body/div[@id='react-root']/section[1]/main[1]/div[1]/div[1]/div[1]/div[1]/form[1]/div[7]/div[1]")]
        [CacheLookup]
        public IWebElement SignuptoAcc;

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[1]/section[1]/main[1]/div[1]/div[1]/div[1]/div[1]/div[4]/div[1]/div[1]/span[1]/span[1]/select[1]")]
        [CacheLookup]
        public IWebElement Month;

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[1]/section[1]/main[1]/div[1]/div[1]/div[1]/div[1]/div[4]/div[1]/div[1]/span[1]/span[2]/select[1]")]
        [CacheLookup]
        public IWebElement Date;

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[1]/section[1]/main[1]/div[1]/div[1]/div[1]/div[1]/div[4]/div[1]/div[1]/span[1]/span[3]/select[1]")]
        [CacheLookup]
        public IWebElement Year;

        [FindsBy(How = How.XPath, Using = "//*[@class='sqdOP  L3NKy _4pI4F  y3zKF     ']")]
        [CacheLookup]
        public IWebElement NextBtn;

    }
}
