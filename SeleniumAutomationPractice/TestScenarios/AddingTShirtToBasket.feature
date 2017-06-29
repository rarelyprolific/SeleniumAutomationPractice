Feature: AddingTShirtToBasket
	On the t-shirts page
	As a user who wants to buy a t-shirt
	I need to be able to add it to my basket

Scenario: Adding a t-shirt to basket
	Given I am in the t-shirts page
	And I have clicked "Add to cart" on the t-shirt 
	When I go to the shopping cart page
	Then there should be a single item in the cart which is a t-shirt
