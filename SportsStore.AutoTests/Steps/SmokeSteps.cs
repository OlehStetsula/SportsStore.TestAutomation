using BoDi;
using Shouldly;
using SportsStore.AutoTests.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace SportsStore.AutoTests.Steps
{
    [Binding]
    class SmokeSteps : BaseSteps
    {
        public SmokeSteps(FeatureContext featureContext, ScenarioContext scenarioContext) : base(featureContext, scenarioContext) { }

        [When(@"I go to Url '(.*)'")]
        public void WhenIGoToUrl(string url)
        {
            var goUrl = $"{baseUrl}/{url}";
            driverManager.GoToUrl(goUrl);
        }

        [Then(@"Response status code is '(.*)'")]
        public void ThenResponseStatusCodeIs(int statusCode)
        {

        }

        [Then(@"There are no js errors in logs")]
        public void ThenThereAreNoJsErrorsInLogs()
        {
            driverManager.GetAmountOfConsoleErrors();
        }

        [Then(@"I see page header on the opened '(.*)' page")]
        public void WhenISeeLogoOnThePage(string page)
        {
            BasePage checkedPage;
            switch (page)
            {
                case "Admin":
                    checkedPage = pageFactory.CreatePage<AdminLoginPage>(driverManager);
                    break;
                case "Cart":
                    checkedPage = pageFactory.CreatePage<CartPage>(driverManager);
                    break;
                case "Home":
                    checkedPage = pageFactory.CreatePage<HomePage>(driverManager);
                    break;
                default:
                    throw new ArgumentException("You tried to open unknown page");
            }

            checkedPage.IsPageHeaderVisible()
              .ShouldBeTrue($"Header didn't appear on '{page}' page");
        }
    }
}
