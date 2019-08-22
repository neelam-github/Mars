Feature: DeleteSkills
	In order to update my profile
	As a skill trader
	I want to delete my skills

@mytag
Scenario: Check if user is able to delete the skills
	Given I have logged in and clicked on the skills tab sucessfully
	When I click on delete
	Then the respective skills should be deleted
