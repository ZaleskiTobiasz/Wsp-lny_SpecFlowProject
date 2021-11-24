using System;
using OpenQA.Selenium;

namespace WspólnySpecFlowProject.Pages
{
    public static class SauceDemoMainPage
    {

        public static IWebElement AddToCartBackpackButton(IWebDriver driver)
        {
            return driver.FindElement(By.CssSelector("#add-to-cart-sauce-labs-backpack"));
        }

        public static IWebElement AddToCartBikeLightButton(IWebDriver driver)
        {
            return driver.FindElement(By.CssSelector("#add-to-cart-sauce-labs-bike-light"));
        }

        public static IWebElement AddToCartT_ShirtButton(IWebDriver driver)
        {
            return driver.FindElement(By.CssSelector("#add-to-cart-sauce-labs-bolt-t-shirt"));
        }

        public static IWebElement AddToCartBikeJacketButton(IWebDriver driver)
        {
            return driver.FindElement(By.CssSelector("#add-to-cart-sauce-labs-fleece-jacket"));
        }

        public static IWebElement AddToCartOnesieButton(IWebDriver driver)
        {
            return driver.FindElement(By.CssSelector("#add-to-cart-sauce-labs-onesie"));
        }

        public static IWebElement AddToCartBikeT_ShirtRedButton(IWebDriver driver)
        {
            return driver.FindElement(By.Name("add-to-cart-test.allthethings()-t-shirt-(red)"));
        }
        public static IWebElement TitleElement(IWebDriver driver)
        {
            return driver.FindElement(By.CssSelector("#header_container > div.header_secondary_container > span"));
        }

        public static IWebElement LoginButton(IWebDriver driver)
        {
            return driver.FindElement(By.CssSelector("#login-button"));
        }

        public static IWebElement ShoppingCartButton(IWebDriver driver)
        {
            return driver.FindElement(By.CssSelector("#shopping_cart_container > a"));
        }
       
    }
}