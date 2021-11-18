Feature: SauceDemoLandingPage


@SauceDemo @ButtonTest
Scenario: Loging
	Given URL is <url>
	And Username is standard_user
	And Password is secret_sauce
	When Username is entered
	And Password is entered
	Then Should enter landing page

	| url |
	| URL |