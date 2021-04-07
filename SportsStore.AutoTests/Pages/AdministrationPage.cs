using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportsStore.AutoTests.Pages
{
    public class AdministrationPage : BasePage
    {
        protected override By pageHeader => By.XPath("//span[text()='SPORTS STORE Administration']");        
    }    
}
