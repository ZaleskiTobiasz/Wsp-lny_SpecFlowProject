Feature: SauceDemo



@HomePage
Scenario: Open homepage
	Given I navigate to "<html>"
	Then Homepage should appear
	Examples:
	| html                 |
	| http://google.com    |
	| http://saucedemo.com |
	| http://onet.pl       |

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

@TestMarka
Scenario: Going to Linkedin company page
	Given I open the"http://saucedemo.com"
	And I am logging in using valid credentials
	And I scroll page down
	When I click on Linkedin ikon on left right side of the page
	Then Linkedin sign in page is opened


