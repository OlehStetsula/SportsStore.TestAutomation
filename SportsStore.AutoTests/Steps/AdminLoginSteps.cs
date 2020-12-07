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
    public sealed class AdminLoginSteps
    {
        private SpecFlowContext context;
        public AdminLoginSteps(ScenarioContext context)
        {
            this.context = context;
        }
        
        [Given(@"Admin panel of website is opened")]
        public void GivenAdminPanelOfWebsiteIsOpened()
        {
            string baseUrl = ConfigurationManager.AppSettings.Get("BaseUrl");
            var driverManager = context.Get<DriverManager>("DriverManager");
            driverManager.GoToUrl("http://localhost:5000");
        }

        [When(@"I enter username '(.*)'")]
        public void WhenIEnterUsername(string p0)
        {
            
        }

        [When(@"I enter password '(.*)'")]
        public void WhenIEnterPassword(string p0)
        {
            
        }

        [Then(@"I am authorized as admin")]
        public void ThenIAmAuthorizedAsAdmin()
        {
            
        }
    }
}
