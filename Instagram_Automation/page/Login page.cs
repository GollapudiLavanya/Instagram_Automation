/*
 * project = InstagramAutomation
 * Author = Lavanya Gollapudi
 * Created Date = 3/10/2021
 */

using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;

namespace Instagram_Automation.page
{
    public class Login_page
    {
        public Login_page(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Name, Using = "username")]
        [CacheLookup]
        public IWebElement UN;

        [FindsBy(How = How.Name, Using = "password")]
        [CacheLookup]
        public IWebElement PW;

        [FindsBy(How = How.XPath, Using = "//body/div[@id='react-root']/section[1]/main[1]/article[1]/div[2]/div[1]/div[1]/form[1]/div[1]/div[3]/button[1]")]
        [CacheLookup]
        public IWebElement loginButton;

    }
}
