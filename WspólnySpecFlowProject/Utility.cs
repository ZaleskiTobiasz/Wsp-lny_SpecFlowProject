using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;


namespace WspólnySpecFlowProject
{
	public static class Utility
	{
		public static void Navigate(IWebDriver driver, string url)
		{
			driver.Navigate().GoToUrl(url);
		}
		public static void ScrollToElementMarekTest(IWebDriver driver, IWebElement element)
		{
			var script = "arguments[0].scrollIntoView(true);";
			IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
			js.ExecuteScript(script, element);
		}
	}
}
