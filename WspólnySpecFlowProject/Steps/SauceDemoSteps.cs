using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using WspólnySpecFlowProject.Drivers;

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

        [Given(@"I navigate to saucedemo\.com")]
        public void GivenINavigateToSaucedemo_Com()
        {
            driver = _scenarioContext.Get<SeleniumDriver>("SeleniumDriver").Setup();
            Utility.NavigateTo("http://saucedemo.com", driver);
        }
        
        [Then(@"Homepage should appear")]
        public void ThenHomepageShouldAppear()
        {
            Assert.IsTrue(driver.FindElement(By.ClassName("login_logo")).Displayed);
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

        [Given(@"I open saucedemo\.com")]
        public void GivenIOpenSaucedemo_Com()
        {
            driver = _scenarioContext.Get<SeleniumDriver>("SeleniumDriver").Setup();
            driver.Navigate().GoToUrl("http://saucedemo.com");
        }

        [Given(@"I log in using valid credentials")]
        public void GivenILogInUsingValidCredentials()
        {
            driver.FindElement(By.Id("user-name")).Click();
            driver.FindElement(By.Id("user-name")).Clear();
            driver.FindElement(By.Id("user-name")).SendKeys("standard_user");
            driver.FindElement(By.Id("password")).Click();
            driver.FindElement(By.Id("password")).Clear();
            driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            driver.FindElement(By.Id("login-button")).Click();
        }

        [When(@"I add to cart first product")]
        public void WhenIAddToCartFirstProduct()
        {
            driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack")).Click();
        }

        [When(@"I add to cart second product")]
        public void WhenIAddToCartSecondProduct()
        {
            driver.FindElement(By.Id("add-to-cart-sauce-labs-bike-light")).Click();
        }

        [Then(@"Shopping cart contains (.*) products")]
        public void ThenShoppingCartContainsProducts(int p0)
        {
            string elementValue = driver.FindElement(By.XPath("//span[.='2']")).Text;
            Assert.AreEqual(elementValue, "2");
        }
    }
}
