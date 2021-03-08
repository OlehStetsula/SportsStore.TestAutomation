using SportsStore.TestAutomation;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using SportsStore.TestAutomation.BasicTools;

namespace SportsStore.AutoTests.Steps
{
    [Binding]
    class AfterScenarioSteps : BaseSteps
    {
        public AfterScenarioSteps(ScenarioContext context) : base(context){}

        [AfterScenario]
        public void AfterScenario()
        {
            if(driverManager != null)
                driverManager.QuitDriver();
            VideoRecorder videoRecorder;
            context.TryGetValue<VideoRecorder>("VideoRecorder", out videoRecorder);
            if (videoRecorder != null)
                videoRecorder.EndRecording();
        }

        [AfterStep]
        public void TakeScreenShot()
        {
            if (((ScenarioContext)context).TestError != null)
            {
                driverManager.TakeScreenshot();
            }
        }        
    }
}
