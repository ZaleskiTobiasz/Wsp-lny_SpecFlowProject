using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;
using WspólnySpecFlowProject.Drivers;
using static WspólnySpecFlowProject.Utility2;
using static WspólnySpecFlowProject.Pages.SauceDemoLogging_Page;
using static WspólnySpecFlowProject.Pages.SauceDemoMainPage;
using static WspólnySpecFlowProject.Pages.SauceDemoCheckoutPage;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System.Threading;

namespace WspólnySpecFlowProject.Steps
{
    [Binding]
    public class SauceDemo_MainPageShoppingSteps
    {
        private readonly ScenarioContext _scenarioContext;

        public SauceDemo_MainPageShoppingSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        static IWebDriver driver;

        [Given(@"I enter correct url")]
        public void GivenIEnterCorrectUrl()
        {
            driver = _scenarioContext.Get<SeleniumDriver>("SeleniumDriver").Setup();
            Navigate(driver, UrlToLoggingPage());
        }
        
        [When(@"Correct username is entered")]
        public void WhenCorrectUsernameIsEntered()
        {
            UsernameLoginTextBox(driver).Click();
            UsernameLoginTextBox(driver).Clear();
            UsernameLoginTextBox(driver).SendKeys(Username());
        }
        
        [When(@"Correct password is entered")]
        public void WhenCorrectPasswordIsEntered()
        {
            PasswordLoginTextBox(driver).Click();
            PasswordLoginTextBox(driver).Clear();
            PasswordLoginTextBox(driver).SendKeys(Password());
        }

        [When(@"Login button is clicked")]
        public void WhenLoginButtonIsClicked()
        {
            LoginButton(driver).Click();
        }

        [Then(@"I enter shopping page")]
        public void ThenIEnterShoppingPage()
        {
            Assert.IsTrue(TitleElement(driver).Displayed);
        }



        [Given(@"Navigate to correct URL")]
        public void GivenNavigateToCorrectURL()
        {
            driver = _scenarioContext.Get<SeleniumDriver>("SeleniumDriver").Setup();
            Navigate(driver, UrlToLoggingPage());
        }

        [Given(@"Pass logging validation")]
        public void GivenPassLoggingValidation()
        {
            UsernameLoginTextBox(driver).Click();
            UsernameLoginTextBox(driver).Clear();
            UsernameLoginTextBox(driver).SendKeys(Username());
            PasswordLoginTextBox(driver).Click();
            PasswordLoginTextBox(driver).Clear();
            PasswordLoginTextBox(driver).SendKeys(Password());
            LoginButton(driver).Click();
        }

        [When(@"Add stuff to cart")]
        public void WhenAddStuffToCart()
        {
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0,0,5));
            wait.Until(drv => drv.FindElement(By.XPath("//*[@id=\"item_2_img_link\"]/img")));
            AddToCartBackpackButton(driver).Click();
            AddToCartBikeJacketButton(driver).Click();
            AddToCartBikeLightButton(driver).Click();
            AddToCartT_ShirtButton(driver).Click();
            Thread.Sleep(500);
            ScrollToElement(driver, AddToCartOnesieButton(driver));
            Thread.Sleep(500);
            AddToCartOnesieButton(driver).Click();
            AddToCartBikeT_ShirtRedButton(driver).Click();
            Thread.Sleep(500);
        }

        [Then(@"Stuff is visible in cart")]
        public void ThenStuffIsVisibleInCart()
        {
            ScrollToElement(driver, ShoppingCartButton(driver));
            Thread.Sleep(500);

            ShoppingCartButton(driver).Click();
            Thread.Sleep(500);

            ScrollToElement(driver, CheckoutButton(driver));
            Thread.Sleep(500);
            Assert.IsTrue(CheckoutButton(driver).Displayed);
        }

    }
}
