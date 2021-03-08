using SportsStore.TestAutomation.BasicTools;
using System;
using TechTalk.SpecFlow;

namespace SportsStore.AutoTests.Steps
{
    [Binding]
    public sealed class BeforeScenarioSteps
    {
        private SpecFlowContext context;
        ConfigManager configManager;
        VideoRecorder videoRecorder;
        public BeforeScenarioSteps(ScenarioContext context)
        {
            this.context = context;
            configManager = ConfigManager.InitConfigManager();
        }
        [BeforeScenario]
        public void BeforeScenario()
        {
            var driverType = Enum.Parse<DriverType>(configManager.GetValue("AppSettings:TestBrowser"));
            var driverManager = DriverManagerFactory.GetDriverManager(driverType);
            context.Add("DriverManager", driverManager);
        }
        [BeforeScenario("RecordVideoReport")]
        public void RecordVideoReport()
        {
            videoRecorder = new VideoRecorder();
            videoRecorder.StartRecordingVideo(((ScenarioContext)context).ScenarioInfo.Title);
            context.Add("VideoRecorder", videoRecorder);
        }
    }

}
