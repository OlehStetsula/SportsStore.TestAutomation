using BoDi;
using SportsStore.AutoTests.Pages;
using SportsStore.TestAutomation;
using SportsStore.TestAutomation.BasicTools;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace SportsStore.AutoTests.Steps
{
    public abstract class BaseSteps
    {
        protected FeatureContext featureContext;
        protected ScenarioContext scenarioContext;
        protected DriverManager driverManager;
        protected PageFactory pageFactory;
        protected ConfigManager configManager;
        protected string baseUrl;


        public BaseSteps(FeatureContext featureContext, ScenarioContext scenarioContext)
        {
            this.featureContext = featureContext;
            this.scenarioContext = scenarioContext;
            driverManager = scenarioContext.Get<DriverManager>("DriverManager");
            pageFactory = new PageFactory();
            configManager = ConfigManager.InitConfigManager();
            baseUrl = configManager.GetValue("AppSettings:BaseUrl");
        }
    }
}
