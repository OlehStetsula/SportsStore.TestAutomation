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
        protected SpecFlowContext context;
        protected DriverManager driverManager;
        protected PageFactory pageFactory;
        protected ConfigManager configManager;
        public BaseSteps(ScenarioContext context)
        {
            this.context = context;
            driverManager = context.Get<DriverManager>("DriverManager");
            pageFactory = new PageFactory();
            configManager = ConfigManager.InitConfigManager();
        }
    }
}
