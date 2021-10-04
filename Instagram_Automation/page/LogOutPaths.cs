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
    public class LogOutPaths
    {
        public LogOutPaths(IWebDriver driver)
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

        [FindsBy(How = How.XPath, Using = "//body/div[@id='react-root']/section[1]/nav[1]/div[2]/div[1]/div[1]/div[3]/div[1]/div[5]/span[1]/img[1]")]
        [CacheLookup]
        public IWebElement profileIcon;

        [FindsBy(How = How.XPath, Using = "//body/div[@id='react-root']/section[1]/nav[1]/div[2]/div[1]/div[1]/div[3]/div[1]/div[5]/div[2]/div[2]/div[2]/div[2]/div[1]")]
        [CacheLookup]
        public IWebElement LogoutBtn;

        [FindsBy(How = How.XPath, Using = "//*[@class='gr27e  ']")]
        [CacheLookup]
        public IWebElement loginpage;
    }
}
