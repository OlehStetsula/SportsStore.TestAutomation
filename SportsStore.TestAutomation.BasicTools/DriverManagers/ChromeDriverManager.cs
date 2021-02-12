using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace SportsStore.TestAutomation
{
    class ChromeDriverManager : DriverManager
    {
        public ChromeDriverManager()
        {
            driver = new ChromeDriver();//Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)
            wait = new WebDriverWait(driver, waitTime);
        }
        protected override IWebDriver GetDriver()
        {
            return driver;
        }

        public override void QuitDriver()
        {
            if(driver != null)
                driver.Quit();
        }
    }
}
