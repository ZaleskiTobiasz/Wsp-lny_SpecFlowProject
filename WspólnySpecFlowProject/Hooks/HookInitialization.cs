using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using WspólnySpecFlowProject.Drivers;

namespace WspólnySpecFlowProject.Hooks
{
	[Binding]
	public sealed class HookInitialization
	{
		// For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

		private readonly ScenarioContext _scenarioContext;

		public HookInitialization(ScenarioContext scenarioContext)
		{
			_scenarioContext = scenarioContext;
		}

		[BeforeScenario]
		public void BeforeScenario()
		{
			SeleniumDriver seleniumDriver = new SeleniumDriver(_scenarioContext);
			_scenarioContext.Set(seleniumDriver, "SeleniumDriver");
		}

		[AfterScenario]
		public void AfterScenario()
		{
			Console.WriteLine("Selenium webdriver quit");
			_scenarioContext.Get<IWebDriver>("WebDriver").Quit();
		}
	}
}
