using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportsStore.TestAutomation
{
    class FirefoxDriverManager : DriverManager
    {
        protected override IWebDriver InitDriver()
        {
            throw new NotImplementedException();
        }
    }
}
