Feature: DeleteLang
	In order to update my profile
	As a skill trader
	I want to delete my language

@mytag
Scenario: check if the user is able to delete the language
	Given I have logged in sucessfully to the profile page
	When I clicked on delete button
	Then the respective language should be deleted
