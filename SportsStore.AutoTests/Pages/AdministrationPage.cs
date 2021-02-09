﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportsStore.AutoTests.Pages
{
    public class AdministrationPage : BasePage
    {
        private By pageHeader => By.XPath("//span[text()='SPORTS STORE Administration']");

        public bool IsPageHeaderVisible()
        {
            return driverManager.IsElementVisible(pageHeader);
        }
    }    
}