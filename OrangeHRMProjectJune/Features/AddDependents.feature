Feature: AddDependents
	In order to register the depandents
	I need to login as employee


@mytag
Scenario:Add Dependent Form
Given that I navigate to "https://opensource-demo.orangehrmlive.com/"
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