Feature: Edit Educations
	In order to update my profile
	As a skill trader
	I want to edit my education details

@mytag
Scenario: Check if user is able to edit education
	Given I have logged in and clicked on Education tab sucessfully
	When I edit the education details
	Then I would able to see the updated details in my list.
