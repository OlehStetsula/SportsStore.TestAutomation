using SportsStore.AutoTests.Pages.PageComponents;
using SportsStore.TestAutomation;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportsStore.AutoTests.Pages
{
    public abstract class BasePage
    {
        protected DriverManager driverManager { get; set; }
        public PageHeader PageHeader { get; set; }

        public void SetDriverManager(DriverManager driverManager)
        {
            this.driverManager = driverManager;
            PageHeader = new PageHeader(driverManager);
        }
    }
}
