using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportsStore.AutoTests.Pages
{
    class HomePage : BasePage
    {
        protected override By pageHeader => By.XPath("//div[text()='SPORTS STORE']");
    }
}
