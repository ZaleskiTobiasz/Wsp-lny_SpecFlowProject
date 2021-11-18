using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace WspólnySpecFlowProject.Steps
{
    [Binding]
    public sealed class SauceDemoLandingPage
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public SauceDemoLandingPage(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"URL is (.*)")]
        public void GivenURLIs(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"Username is standard_user")]
        public void GivenUsernameIsStandard_User()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"Password is secret_sauce")]
        public void GivenPasswordIsSecret_Sauce()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Username is entered")]
        public void WhenUsernameIsEntered()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Password is entered")]
        public void WhenPasswordIsEntered()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Should enter landing page")]
        public void ThenShouldEnterLandingPage(Table table)
        {
            ScenarioContext.Current.Pending();
        }

    }
}
