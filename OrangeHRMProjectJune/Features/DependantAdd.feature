Feature: DependantAdd
	Simple calculator for adding two numbers

@mytag
Scenario:DependantAddForm
Given The user navigate to "https://opensource-demo.orangehrmlive.com/"
And The user Enter Admin Username 
And The user Enter Admin Password 
And The user Click Login 
And The user Click on PIM
And The User Click on Add Employee
And The user Enter Firstname 
And The user Enter Lastname 
And The user Enter Employee Id number
And The user Click On Choose file"\SportCar.jpg"
And The user Check the box for create login details
And The user Enter Username 
And The user Enter Password 
And The user Enter confirm Password 
And The user Click Enabled for Status
And The user generate a save button click
And I Click on Dependents
And I Click Add
And I User Enter Name
And I Select Relationship
And I click on Calender
And I Select month
And I Select year
And I select day
When I Click on Save
#Then Confirm you have successfully added dependents
