using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace SportsStore.TestAutomation
{
    public abstract class DriverManager
    {
        protected IWebDriver driver;        
        protected WebDriverWait wait;
        protected TimeSpan waitTime = TimeSpan.FromSeconds(10);//Parse(ConfigurationManager.AppSettings["WaitTime"]);
        protected abstract IWebDriver GetDriver();
        public abstract void QuitDriver();

        public IWebElement WaitAndFindElement(By elementLocator)
        {
            try
            {
                return wait.Until(e => e.FindElement(elementLocator));
            }
            catch (Exception)
            {
                throw new Exception($"Element not found by {elementLocator.ToString()}");
            }
            
        }

        public IEnumerable<IWebElement> WaitAndFindElements(By elementLocator)
        {
            try
            {
                return wait.Until(e => e.FindElements(elementLocator));
            }
            catch (Exception)
            {
                throw new Exception($"Elements not found by {elementLocator.ToString()}");
            }
        }

        public void GoToUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
        }
    }    
}
