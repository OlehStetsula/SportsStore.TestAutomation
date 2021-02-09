using SportsStore.AutoTests.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using Shouldly;

namespace SportsStore.AutoTests.Steps
{
    [Binding]
    class AdministrationSteps : BaseSteps
    {        
        public AdministrationSteps(ScenarioContext context) : base(context) { } 
        
        [Then(@"I am authorized as admin")]
        public void ThenIAmAuthorizedAsAdmin()
        {
            pageFactory.CreatePage<AdministrationPage>(driverManager)
                .IsPageHeaderVisible()
                .ShouldBeTrue("Administration Page Header didn't appear");
        }    
    }
}
