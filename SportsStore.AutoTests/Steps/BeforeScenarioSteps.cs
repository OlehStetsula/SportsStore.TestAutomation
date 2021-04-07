using BoDi;
using SportsStore.TestAutomation;
using SportsStore.TestAutomation.BasicTools;
using System;
using TechTalk.SpecFlow;

namespace SportsStore.AutoTests.Steps
{
    [Binding]
    public sealed class BeforeScenarioSteps
    {
        ConfigManager configManager;
        FeatureContext featureContext;
        ScenarioContext scenarioContext;

        public BeforeScenarioSteps(FeatureContext featureContext, ScenarioContext scenarioContext)
        {
            this.featureContext = featureContext;
            this.scenarioContext = scenarioContext;
            configManager = ConfigManager.InitConfigManager();
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            var driverType = Enum.Parse<DriverType>(configManager.GetValue("AppSettings:TestBrowser"));
            var driverManager = DriverManagerFactory.GetDriverManager(driverType);
            scenarioContext.Add("DriverManager", driverManager);
        }        
    }

}
