using OpenQA.Selenium;
using SportsStore.TestAutomation;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportsStore.AutoTests.Pages
{
    public class AdminLoginPage : BasePage
    {
        private By UserNameInput => By.Id("Name");
        private By PasswordInput => By.Id("Password");
        private By LoginButton => By.CssSelector("button.btn.btn-primary");

        void EnterUserName(string userName)
        {
            driverManager.SendKeys(UserNameInput, userName);
        }

        void EnterPassword(string password)
        {
            driverManager.SendKeys(PasswordInput, password);
        }

        void ClickLogginButton()
        {
            driverManager.ClickOnElement(LoginButton);
        }

        public void Login(string userName, string password)
        {
            EnterUserName(userName);
            EnterPassword(password);
            ClickLogginButton();
        }
    }
}
