Feature: SpecFlowFeature2
	In order to update my profile
	As a skill trader
	I would like to add skills that I have.

@mytag
Scenario: Check if user is able to add new skills
	Given I have logged into profile page sucessfully
	And I clicked on Add skills tab under profile page
	When I add a new skill
	Then that skill should be displayed on my listing
