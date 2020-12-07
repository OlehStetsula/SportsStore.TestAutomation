using SportsStore.TestAutomation.BasicTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SportsStore.AutoTests.Steps
{
    [Binding]
    public sealed class BeforeScenarioSteps
    {
        private SpecFlowContext context;
        public BeforeScenarioSteps(ScenarioContext context)
        {
            this.context = context;
        }
        [BeforeScenario]
        public void BeforeScenario()
        {
            DriverType driverType = DriverType.Chrome;
            var driverManager = DriverManagerFactory.GetDriverManager(driverType);
            context.Add("DriverManager", driverManager);
        }
    }
}
