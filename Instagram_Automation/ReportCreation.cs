/*
 * project = InstagramAutomation
 * Author = Lavanya Gollapudi
 * Created Date = 3/10/2021
 */

using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using OpenQA.Selenium;

namespace Instagram_Automation
{
    public class ReportCreation
    {
        public static ExtentHtmlReporter htmlReporter;
        public static ExtentReports extent;
        public static ExtentTest test;

        public static ExtentReports report()
        {
            if (extent == null)
            {
                string reportPath = @"C:\Users\lavanya.g\source\repos\Instagram_Automation\Instagram_Automation\Reports\InstaReports.html";
                htmlReporter = new ExtentHtmlReporter(reportPath);
                extent = new ExtentReports();
                extent.AttachReporter(htmlReporter);
                extent.AddSystemInfo("OS", "Windows");
                extent.AddSystemInfo("UserName", "Lavanya");
                extent.AddSystemInfo("ProviderName", "Lavanya");
                extent.AddSystemInfo("Domain", "QA");
                extent.AddSystemInfo("ProjectName", "Insta Automation");

                string conifgPath = @"C:\Users\lavanya.g\source\repos\Instagram_Automation\Instagram_Automation\Insta.xml";
                htmlReporter.LoadConfig(conifgPath);
            }
            return extent;
        }
    }
}
