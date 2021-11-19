using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace WspólnySpecFlowProject.Pages
{
    public static class SauceDemoLogging_Page
    {
        public static string UrlToLoggingPage()
        {
            return "https://www.saucedemo.com/";
        }
        public static IWebElement UsernameLoginTextBox(IWebDriver driver)
        {
            return driver.FindElement(By.CssSelector("#user-name"));
        }

        public static IWebElement PasswordLoginTextBox(IWebDriver driver)
        {
            return driver.FindElement(By.CssSelector("#password"));
        }

    }
}
