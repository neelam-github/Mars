Feature: DeleteEducations
	In order to update my profile
	As a skill trader
	I want to delete my educations

@mytag
Scenario: Check if user is able to delete the educations
	Given I have logged in and clicked on the education tab sucessfully
	When I click on delete button
	Then the respective education should get deleted
