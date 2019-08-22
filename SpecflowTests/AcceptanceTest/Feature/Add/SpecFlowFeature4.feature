Feature: SpecFlowFeature4
	In order to update my profile
	As a skill trader
	I would like to add the certifications I have

@mytag
Scenario: Check if user is able to add new certifications
	Given I have logged into the profile page sucessfully
	And I have clicked on the Certification tab under the profile page.
	When I add a new certification
	Then that certification should be displayed on my listing.
