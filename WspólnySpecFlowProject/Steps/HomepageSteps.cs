using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using WspólnySpecFlowProject.Drivers;

namespace WspólnySpecFlowProject.Steps
{
    [Binding]
    public class HomepageSteps
    {
        IWebDriver driver;

        private readonly ScenarioContext _scenarioContext;

        public HomepageSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I navigate to saucedemo\.com")]
        public void GivenINavigateToSaucedemo_Com()
        {
            driver = _scenarioContext.Get<SeleniumDriver>("SeleniumDriver").Setup();
            driver.Navigate().GoToUrl("http://saucedemo.com");
        }
        
        [Then(@"Homepage should appear")]
        public void ThenHomepageShouldAppear()
        {
            Assert.IsTrue(driver.FindElement(By.ClassName("login_logo")).Displayed);
        }
    }
}
