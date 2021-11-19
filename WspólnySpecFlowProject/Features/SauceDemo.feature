Feature: SauceDemo



@HomePage
Scenario: Open homepage
	Given I navigate to "http://saucedemo.com"
	Then Homepage should appear

@Login
Scenario: Logging in with valid username and password
	Given I open homepage "http://saucedemo.com"
	When I enter valid username
	And I enter valid password
	Then I successfully log in

@ToCart
Scenario: Adding products to cart
	Given I open "http://saucedemo.com"
	And I log in using valid credentials
	When I add to cart first product
	And I add to cart second product
	Then Shopping cart contains 2 products