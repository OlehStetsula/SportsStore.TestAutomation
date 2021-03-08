using OpenQA.Selenium;
using SportsStore.TestAutomation;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportsStore.AutoTests.Pages.PageComponents
{
    public class PageHeader
    {
        private DriverManager driverManager;
        private By pageHeader => By.XPath("//span[text()='SPORTS STORE']");
        
        public PageHeader(DriverManager driverManager)
        {
            this.driverManager = driverManager;
        }

        public bool IsPageHeaderVisible()
        {
            return driverManager.IsElementVisible(pageHeader);
        }
    }
}
