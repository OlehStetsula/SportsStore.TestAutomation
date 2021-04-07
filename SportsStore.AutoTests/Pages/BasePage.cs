using OpenQA.Selenium;
using SportsStore.TestAutomation;

namespace SportsStore.AutoTests.Pages
{
    public abstract class BasePage
    {
        protected DriverManager driverManager { get; set; }
        protected virtual By pageHeader => By.XPath("//span[text()='SPORTS STORE']");

        public void SetDriverManager(DriverManager driverManager)
        {
            this.driverManager = driverManager;
        }

        public bool IsPageHeaderVisible()
        {
            return driverManager.IsElementVisible(pageHeader);
        }
    }
}
