Feature: Edit Language
	In order to edit my profile
	As a skill trader
	I want to edit my language

@mytag
Scenario:Check if we are able to edit language
	Given I have logged into the profile page sucessfully
	When I edit my language and/or language skills
	Then the updated records should be visible
