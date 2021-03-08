﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using SeleniumExtras.WaitHelpers;
using SportsStore.TestAutomation.BasicTools;
using System.Linq;
using System.IO;

namespace SportsStore.TestAutomation
{
    public abstract class DriverManager
    {
        protected IWebDriver driver;        
        protected WebDriverWait wait;
        protected ConfigManager configManager;
        protected TimeSpan waitTime => TimeSpan.FromSeconds(double.Parse(configManager.GetValue("AppSettings:WaitTime")));
        protected bool HeadlessMode => bool.Parse(configManager.GetValue("AppSettings:HeadlessMode"));

        public DriverManager()
        {
            configManager = ConfigManager.InitConfigManager();
        }

        protected IWebDriver GetDriver()
        {
            return driver;
        }

        public void QuitDriver()
        {
            if (driver != null)
                driver.Quit();
        }

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

        public void SendKeys(By elementLocator, string input)
        {
            WaitAndFindElement(elementLocator).SendKeys(input);
        }

        public void ClickOnElement(By elementLocator)
        {
            WaitAndFindElement(elementLocator).Click();
        }

        public bool IsElementVisible(By elementLocator)
        {
            try
            {
                wait.Until(e => e.FindElement(elementLocator).Displayed);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public int GetAmountOfConsoleErrors()
        {
            var logs = driver.Manage().Logs;
            var logEntries = logs.GetLog(LogType.Browser);
            List<LogEntry> errorLogs = logEntries.Where(n => n.Level == LogLevel.Severe).ToList();

            if (errorLogs.Count != 0)
            {
                foreach(LogEntry logEntry in logEntries)
                {
                    Console.WriteLine("Found error in logs: " + logEntry.Message);
                }
            }

            return errorLogs.Count;
        }

        public void TakeScreenshot()
        {
            try
            {
                var artifactDirectory = Path.Combine(Directory.GetCurrentDirectory(), "ScreenshotsAndSources");
                if (!Directory.Exists(artifactDirectory))
                    Directory.CreateDirectory(artifactDirectory);

                string pageSource = driver.PageSource;
                string sourceFilePath = Path.Combine(artifactDirectory, Path.GetFileNameWithoutExtension(Path.GetTempFileName() + "_source.html"));
                File.WriteAllText(sourceFilePath, pageSource, Encoding.UTF8);
                Console.WriteLine($"Page source: {new Uri(sourceFilePath)}");

                ITakesScreenshot takesScreenshot = driver as ITakesScreenshot;

                if (takesScreenshot != null)
                {
                    var screenshot = takesScreenshot.GetScreenshot();
                    string screenshotFilePath = Path.Combine(artifactDirectory, Path.GetFileNameWithoutExtension(Path.GetTempFileName() + "_screenshot.png"));
                    screenshot.SaveAsFile(screenshotFilePath, ScreenshotImageFormat.Png);
                    Console.WriteLine($"Screenshot: {new Uri(screenshotFilePath)}");
                } 
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Error while taking screenshot: {ex}");
            }
        }
    }    
}
