Feature: SauceDemoMainPageShopping

@Logging
Scenario: Loging
	Given I enter correct url
	When Correct username is entered
	And Correct password is entered
	And Login button is clicked
	Then I enter shopping page

 @Shopping
Scenario: Adding stuff to cart
	Given Navigate to correct URL
	And Pass logging validation
	When Add stuff to cart
	Then Stuff is visible in cart