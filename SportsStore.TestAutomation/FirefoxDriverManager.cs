﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportsStore.TestAutomation
{
    class FirefoxDriverManager : DriverManager
    {
        public override IWebDriver GetDriver()
        {
            throw new NotImplementedException();
        }

        public override void QuitDriver()
        {
            throw new NotImplementedException();
        }
    }
}
