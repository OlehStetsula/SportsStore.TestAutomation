using SportsStore.AutoTests.Pages;
using SportsStore.TestAutomation;
using SportsStore.TestAutomation.BasicTools;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SportsStore.AutoTests.Steps
{
    [Binding]
    public sealed class AdminLoginSteps : BaseSteps
    {
        public AdminLoginSteps(ScenarioContext context) : base(context){ } 
        
        [Given(@"Admin panel of website is opened")]
        public void GivenAdminPanelOfWebsiteIsOpened()
        {
            string baseUrl = configManager.GetValue("BaseUrl");            
            driverManager.GoToUrl($"{baseUrl}/Admin");
        }

        [When(@"I enter username '(.*)' and password '(.*)'")]
        public void WhenIEnterUsername(string userName, string password)
        {
            pageFactory.CreatePage<AdminLoginPage>(driverManager)
                .Login(userName, password);
        }        
    }
}
