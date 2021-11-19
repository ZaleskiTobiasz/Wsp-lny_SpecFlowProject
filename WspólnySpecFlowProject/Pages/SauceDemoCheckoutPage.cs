using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace WspólnySpecFlowProject.Pages
{
    public static class SauceDemoCheckoutPage
    {
        public static IWebElement CheckoutButton(IWebDriver driver)
        {
            return driver.FindElement(By.CssSelector("#checkout"));
        }
        public static IWebElement RemoveBackpackButton(IWebDriver driver)
        {
            return driver.FindElement(By.CssSelector("#remove-sauce-labs-backpack"));
        }
        public static IWebElement RemoveBikeLightButton(IWebDriver driver)
        {
            return driver.FindElement(By.CssSelector("#remove-sauce-labs-bike-light"));
        }
        public static IWebElement RemoveT_ShirtButton(IWebDriver driver)
        {
            return driver.FindElement(By.CssSelector("#remove-sauce-labs-bolt-t-shirt"));
        }
        public static IWebElement RemoveJacketButton(IWebDriver driver)
        {
            return driver.FindElement(By.CssSelector("#remove-sauce-labs-fleece-jacket"));
        }
        public static IWebElement RemoveOnesieButton(IWebDriver driver)
        {
            return driver.FindElement(By.CssSelector("#remove-sauce-labs-onesie"));
        }
        public static IWebElement RemoveT_ShirtRedButton(IWebDriver driver)
        {
            return driver.FindElement(By.CssSelector("#remove-test\\.allthethings\\(\\)-t-shirt-\\(red\\)"));
        }

    }
}