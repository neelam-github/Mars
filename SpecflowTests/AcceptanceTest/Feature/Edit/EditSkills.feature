Feature: Edit Skills
	In order to update my profile
	As a skill trader
	I want to edit my skills

@mytag
Scenario: Check if user is able to edit their skills
	Given I have logged in and clicked on skills tab sucessfully
	When I edit the skills 
	Then the updated skills shoukd be shown on the list
