Feature: LoggingIn
	On the sign in page
	As a user who has not entered an email address when attempting to log in
	I need to be told to enter an email address

Scenario: Attempting to log in without an email address should fail
	Given I am in the sign in page
	When I press the Sign In button without entering any login details
	Then I should see an error saying an email address is required
