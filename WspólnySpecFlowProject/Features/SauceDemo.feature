Feature: SauceDemo



@HomePage
Scenario: Open homepage
	Given I navigate to saucedemo.com
	Then Homepage shoul appear

@Login
Scenario: Logging in with valid username and password
	Given I open homepage
	When I enter valid username
	And I enter valid password
	Then I successfully log in