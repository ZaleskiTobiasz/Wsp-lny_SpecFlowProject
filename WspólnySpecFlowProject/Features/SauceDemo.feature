Feature: SauceDemo



@HomePage
Scenario: Open homepage
	Given I navigate to saucedemo.com
	Then Homepage should appear

@Login
Scenario: Logging in with valid username and password
	Given I open homepage
	When I enter valid username
	And I enter valid password
	Then I successfully log in

	@ToCart
Scenario: Adding products to cart
	Given I open saucedemo.com
	And I log in using valid credentials
	When I add to cart first product
	And I add to cart second product
	Then Shopping cart contains 2 products