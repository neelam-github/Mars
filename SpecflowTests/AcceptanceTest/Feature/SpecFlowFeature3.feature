Feature: SpecFlowFeature3
	In order to update my profile
	As a Skill trader
	I would like to add education that I have

@mytag
Scenario: Check if user is able to add new education
	Given I have logged into profile page sucessfully
	And I have clicked on education tab under profile page
	When I add a new Education
	Then that education should be displayed on my listing
