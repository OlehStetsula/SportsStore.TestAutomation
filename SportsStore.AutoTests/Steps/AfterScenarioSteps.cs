using SportsStore.TestAutomation;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace SportsStore.AutoTests.Steps
{
    [Binding]
    class AfterScenarioSteps
    {
        private SpecFlowContext context;
        public AfterScenarioSteps(ScenarioContext context)
        {
            this.context = context;
        }

        [AfterScenario]
        public void AfterScenario()
        {
            var driverManager = context.Get<DriverManager>("DriverManager");
            driverManager.QuitDriver();
        }
    }
}
