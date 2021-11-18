using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace WspólnySpecFlowProject
{
    public static class Utility
    {

        public static void NavigateTo(string url, IWebDriver driver)
        {
            driver.Navigate().GoToUrl(url);
        }

    }
}
