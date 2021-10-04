/*
 * project = InstagramAutomation
 * Author = Lavanya Gollapudi
 * Created Date = 3/10/2021
 */

using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Instagram_Automation.page
{
    public class ProfilePhoto
    {
        public ProfilePhoto(IWebDriver driver)
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

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Profile')]")]
        [CacheLookup]
        public IWebElement ProfileButton;

        [FindsBy(How = How.XPath, Using = "//*[@class='be6sR']")]
        [CacheLookup]
        public IWebElement PhotoUploadIcon;

        [FindsBy(How = How.XPath, Using = "//*[@class='_7UhW9     LjQVu     qyrsm KV-D4          uL8Hv         ']")]
        [CacheLookup]
        public IWebElement ChangeProfilePhoto;


        [FindsBy(How = How.XPath, Using = "//*[@class='aOOlW  bIiDR  ']")]
        [CacheLookup]
        public IWebElement UploadPhoto;
    }
}
