using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using WspólnySpecFlowProject.Drivers;
using static WspólnySpecFlowProject.Utility;
using static WspólnySpecFlowProject.Pages.SauceDemoPages;
using System.Threading;
using System.Linq;

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

            Utility.Navigate(driver, url);

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
            Utility.Navigate(driver, url);
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
            Utility.Navigate(driver, url);
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

        [Given(@"I open the""(.*)""")]
        public void GivenIOpenThe(string url)
        {
            driver = _scenarioContext.Get<SeleniumDriver>("SeleniumDriver").Setup();

            Utility.Navigate(driver, url);
        }

        [Given(@"I am logging in using valid credentials")]
        public void GivenIamLogInUsingValidCredentials()
        {
            UsernameInput(driver).Click();
            UsernameInput(driver).Clear();
            UsernameInput(driver).SendKeys("standard_user");
            PasswordInput(driver).Click();
            PasswordInput(driver).Clear();
            PasswordInput(driver).SendKeys("secret_sauce");
            LoginButton(driver).Click();
        }

        [Given(@"I scroll page down")]
        public void GivenIScrollPageDown()
        {
            ScrollToElementMarekTest(driver, LinkedInIconButton(driver));
            Thread.Sleep(500);
        }

        [When(@"I click on Linkedin ikon on left right side of the page")]
        public void WhenIClickOnLinkedinIkonOnLeftRightSideOfThePage()
        {
            LinkedInIconButton(driver).Click();
            Thread.Sleep(5000);
            driver.SwitchTo().Window(driver.WindowHandles.Last());
        }
        

        [Then(@"Linkedin sign in page is opened")]
        public void ThenLinkedinSignInPageIsOpened()
        {
            Assert.IsTrue(LinkedInSingingUpPage(driver).Displayed);
        }

    }
}