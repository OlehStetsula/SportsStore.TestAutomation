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
        protected override IWebDriver InitDriver()
        {
            var options = new ChromeOptions();
            if(HeadlessMode)
                options.AddArgument("headless");
            options.AddArgument("--start-maximized");
            options.AddArgument("--disable-notifications");
            options.SetLoggingPreference(LogType.Browser, LogLevel.Warning);
            var driver = new ChromeDriver(options);
            return driver;
        }
    }
}
