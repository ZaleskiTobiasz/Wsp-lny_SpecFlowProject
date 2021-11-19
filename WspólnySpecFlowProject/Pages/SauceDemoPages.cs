using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace WspólnySpecFlowProject.Pages
{
	public static class SauceDemoPages
	{
		public static IWebElement LoginLogo(IWebDriver driver)
		{
			return driver.FindElement(By.ClassName("login_logo"));
		}

		public static IWebElement UsernameInput(IWebDriver driver)
		{
			return driver.FindElement(By.Id("user-name"));
		}

		public static IWebElement PasswordInput(IWebDriver driver)
		{
			return driver.FindElement(By.Id("password"));
		}
		public static IWebElement LoginButton(IWebDriver driver)
		{
			return driver.FindElement(By.Id("login-button"));
		}

		public static IWebElement AppLogo(IWebDriver driver)
		{
			return driver.FindElement(By.XPath("//div[@class='app_logo']"));
		}

		public static IWebElement BackpackToCartButton(IWebDriver driver)
		{
			return driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack"));
		}
		public static IWebElement BikeLightToCartButton(IWebDriver driver)
		{
			return driver.FindElement(By.Id("add-to-cart-sauce-labs-bike-light"));
		}
		public static int BasketCounter(IWebDriver driver)
		{
			int basketCounter = Int32.Parse(driver.FindElement(By.XPath("//span[.='2']")).Text);
			return basketCounter;
		}
	}
}
