using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using WspólnySpecFlowProject.Drivers;
using static WspólnySpecFlowProject.Utility;
using static WspólnySpecFlowProject.Pages.SauceDemoPages;

namespace WspólnySpecFlowProject.Steps
{
    [Binding]
    public class SauceDemoSteps
    {
        IWebDriver driver;

        private readonly ScenarioContext _scenarioContext;

        public SauceDemoSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I navigate to ""(.*)""")]
        public void GivenINavigateToSaucedemo_Com(string url)
        {
            driver = _scenarioContext.Get<SeleniumDriver>("SeleniumDriver").Setup();

            Navigate(driver, url);

        }
        
        [Then(@"Homepage should appear")]
        public void ThenHomepageShouldAppear()
        {
            Assert.IsTrue(LoginLogo(driver).Displayed);
        }

        [Given(@"I open homepage ""(.*)""")]
        public void GivenIOpenHomepage(string url)
        {
            driver = _scenarioContext.Get<SeleniumDriver>("SeleniumDriver").Setup();
            Navigate(driver, url);
        }

        [When(@"I enter valid username")]
        public void WhenIEnterValidUsername()
        {
            UsernameInput(driver).Click();
            UsernameInput(driver).Clear();
            UsernameInput(driver).SendKeys("standard_user");

        }

        [When(@"I enter valid password")]
        public void WhenIEnterValidPassword()
        {
            PasswordInput(driver).Click();
            PasswordInput(driver).Clear();
            PasswordInput(driver).SendKeys("secret_sauce");
            LoginButton(driver).Click();

        }

        [Then(@"I successfully log in")]
        public void ThenISuccessfullyLogIn()
        {
            Assert.IsTrue(AppLogo(driver).Displayed);
        }

        [Given(@"I open ""(.*)""")]
        public void GivenIOpenSaucedemo_Com(string url)
        {
            driver = _scenarioContext.Get<SeleniumDriver>("SeleniumDriver").Setup();
            Navigate(driver, url);
        }

        [Given(@"I log in using valid credentials")]
        public void GivenILogInUsingValidCredentials()
        {
            UsernameInput(driver).Click();
            UsernameInput(driver).Clear();
            UsernameInput(driver).SendKeys("standard_user");
            PasswordInput(driver).Click();
            PasswordInput(driver).Clear();
            PasswordInput(driver).SendKeys("secret_sauce");
            LoginButton(driver).Click();
        }

        [When(@"I add to cart first product")]
        public void WhenIAddToCartFirstProduct()
        {
            BackpackToCartButton(driver).Click();
        }

        [When(@"I add to cart second product")]
        public void WhenIAddToCartSecondProduct()
        {
            BikeLightToCartButton(driver).Click();
        }

        [Then(@"Shopping cart contains (.*) products")]
        public void ThenShoppingCartContainsProducts(int number)
        {
            Assert.AreEqual(BasketCounter(driver), number);
        }
    }
}