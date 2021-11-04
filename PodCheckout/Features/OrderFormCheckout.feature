Feature: OrderForm
	In order to order from the website 
	I need to signup and add to basket 

@mytag
Scenario: OrderFormCheckout
	Given I Navigate to the form "https://checkout.pod-point.com/"
	And  I need to select Make 
	And I need to select model
	And I click New Car
	And I click Universal Charger
	And I click Charges a Bmw330e
	And I select Extended warranty
	And I click Cable Bag
	And I click on next button
    And Enter my FirstName "TEMM"
    And I enter LastName "BELLA"
    And I enter Phone Number "07944610699"
    And I Enter Email address "Temmywealth@yahoo.com" 
	And I click dont Contact me by phone
	And Don't contact me by Email
	And User click I'd prefer not to recieve update
	When I click on submit button
	#Then I should be able to submit my details for installation