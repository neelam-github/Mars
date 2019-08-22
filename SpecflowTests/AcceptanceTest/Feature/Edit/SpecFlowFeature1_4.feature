Feature: Edit Certifications
	In order to update my profile
	As a skill trader
	I want to edit my certifications

@mytag
Scenario: Check if user is able to edit certifications
	Given I have logged in and clicked on certification tab sucessfully.
	When I edit certifications
	Then the updated certifications should be shown on the list
