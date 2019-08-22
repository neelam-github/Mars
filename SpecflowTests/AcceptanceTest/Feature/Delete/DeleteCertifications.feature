Feature: DeleteCertifications
	In order to update my skills
	As a skill trader
	I want to be delete my certifications

@mytag
Scenario: Check if user is able to delete the certifications
	Given I have logged in and clicked on the certification tab sucessfully
	When I click on delete
	Then the respective certification should be deleted
