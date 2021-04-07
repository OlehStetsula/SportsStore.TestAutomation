using SportsStore.AutoTests.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using Shouldly;
using BoDi;

namespace SportsStore.AutoTests.Steps
{
    [Binding]
    class AdministrationSteps : BaseSteps
    {        
        public AdministrationSteps(FeatureContext featureContext, ScenarioContext scenarioContext) : base(featureContext, scenarioContext) { } 
        
        [Then(@"I am authorized as admin")]
        public void ThenIAmAuthorizedAsAdmin()
        {
            //pageFactory.CreatePage<AdministrationPage>(driverManager)
            //    .IsPageHeaderVisible()
            //    .ShouldBeTrue("Administration Page Header didn't appear");
        }    
    }
}
