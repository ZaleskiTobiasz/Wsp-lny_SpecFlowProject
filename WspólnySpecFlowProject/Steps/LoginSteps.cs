using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using WspólnySpecFlowProject.Drivers;

namespace WspólnySpecFlowProject.Steps
{

    [Binding]
    public class LoginSteps
    {
        IWebDriver driver;
        private readonly ScenarioContext _scenarioContext;

        public LoginSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }


        [Given(@"I open homepage")]
        public void GivenIOpenHomepage()
        {
            driver = _scenarioContext.Get<SeleniumDriver>("SeleniumDriver").Setup();
            driver.Navigate().GoToUrl("http://saucedemo.com");
        }
        
        [When(@"I enter valid username")]
        public void WhenIEnterValidUsername()
        {
            driver.FindElement(By.Id("user-name")).Click();
            driver.FindElement(By.Id("user-name")).Clear();
            driver.FindElement(By.Id("user-name")).SendKeys("standard_user");

        }

        [When(@"I enter valid password")]
        public void WhenIEnterValidPassword()
        {
            driver.FindElement(By.Id("password")).Click();
            driver.FindElement(By.Id("password")).Clear();
            driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            driver.FindElement(By.Id("login-button")).Click();

        }

        [Then(@"I successfully log in")]
        public void ThenISuccessfullyLogIn()
        {
            Assert.IsTrue(driver.FindElement(By.XPath("//div[@class='app_logo']")).Displayed);
        }
    }
}
