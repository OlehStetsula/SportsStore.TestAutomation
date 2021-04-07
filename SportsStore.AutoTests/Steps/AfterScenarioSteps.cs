using SportsStore.TestAutomation;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using SportsStore.TestAutomation.BasicTools;
using BoDi;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace SportsStore.AutoTests.Steps
{
    [Binding]
    class AfterScenarioSteps : BaseSteps
    {
        public AfterScenarioSteps(FeatureContext featureContext, ScenarioContext scenarioContext) : base(featureContext, scenarioContext) {}

        [AfterScenario]
        public void AfterScenario()
        {
            if(driverManager != null)
                driverManager.QuitDriver();
        }

        [AfterStep]
        public void TakeScreenShot(FeatureContext featureContext)
        {
            if (TestContext.CurrentContext.Result.Outcome == ResultState.Failure)
            {
                driverManager.TakeScreenshot();
            }
        }        
    }
}
