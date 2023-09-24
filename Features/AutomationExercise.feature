Feature: Feature1

As a new user I want to be able to register login and delete a new user account



Scenario: Successfully register and delete a new user account
	    And I navigate to the Automation Practice url 

	Then the home page should be visible

	When I Click on Signup / Login button
	Then New User Signup! should be visible

	When I fill in the following data '<name>' , '<email>'
		And I Click the Signup button
	Then ENTER ACCOUNT INFORMATION should be visible

	When  I Click the 'Mr.' option for the Title
	    And I fill in the following datas '<Password>'
		And I select '7' from the Day of birth dropdown menu
		And I select 'May' from the Month of birth dropdown menu
		And I select '1990' from the Year of birth dropdown menu
		And I Select checkbox Sign up for our newsletter
		And I Select checkbox Receive special offers from our partners

		And I Enter the following form details 'firstName' , 'lastName' , 'company' , 'address' , 'address2' , 'state' , 'city' , 'zipcode' , 'mobileNumber'
		
		And And I select 'USA' from the Country dropdown menu

	    And I click Create Account button
	Then ACCOUNT CREATED! text should be displayed

	When I Click on login

	Then 'Logged in as Test User'text should be visible

	When I Click Delete Account  

	