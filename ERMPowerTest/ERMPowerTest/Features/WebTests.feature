Feature: WebTests

@Chrome
Scenario: I register for the application access
	Given I use web driver to test web application located at 'https://www.nopcommerce.com/'
	When I go to registeration page
	And I provide registeration details for application access
	| FirstName | LastName  | Email                | Username | Country   | YourRole              | Password | ConfirmPassword |
	| Abhishek  | Zunjurwad | azunjurwad@gmail.com | abhis86  | Australia | Technical / developer | Test123# | Test123#        |
	Then I should get successful registration message

#@Chrome
#Scenario: I login to the application using correct login details - Note: This test case is not implemented because I am getting error on login unless I check my email and confirm the registration
	#Given I use web driver to test web application located at 'https://www.nopcommerce.com/'
	#When I provide username and password to login to application
	#| UserName | Password |
	#| abhis86  | Test123# |
	#Then I should be logged into the application and land on the home page