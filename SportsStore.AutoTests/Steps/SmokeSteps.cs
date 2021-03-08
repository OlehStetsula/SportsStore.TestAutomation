using Shouldly;
using SportsStore.AutoTests.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace SportsStore.AutoTests.Steps
{
    class SmokeSteps : BaseSteps
    {
        public SmokeSteps(ScenarioContext context) : base(context) { }

        [When(@"I go to Url '(.*)'")]
        public void WhenIGoToUrl(string url)
        {
            driverManager.GoToUrl($"{baseUrl}/{url}");
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

        [Then(@"I see page header on the opened page")]
        public void WhenISeeLogoOnThePage()
        {
            pageFactory.CreatePage<AdministrationPage>(driverManager)
                .IsPageHeaderVisible()
                .ShouldBeTrue("Page Header didn't appear");
        }
    }
}
