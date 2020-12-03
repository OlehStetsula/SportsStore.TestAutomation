using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportsStore.TestAutomation
{
    public abstract class DriverManager
    {
        protected IWebDriver driver;
        public abstract IWebDriver GetDriver();
        public abstract void QuitDriver();
    }
}
