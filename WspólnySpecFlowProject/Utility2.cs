using OpenQA.Selenium;
using System;

namespace WspólnySpecFlowProject
{
	public static class Utility2
	{
		public static string Username()
        {
            return "standard_user";
        }
		public static string Password()
        {
            return "secret_sauce";
        }
        public static void Navigate(IWebDriver driver, string url)
		{
			driver.Navigate().GoToUrl(url);
		}

        public static void ScrollToElement(IWebDriver driver, IWebElement element)
        {
            var script = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript(script, element);
        }

    }
    
}