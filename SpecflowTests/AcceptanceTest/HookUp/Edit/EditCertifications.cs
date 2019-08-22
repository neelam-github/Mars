using System;
using TechTalk.SpecFlow;

namespace SpecflowTests.AcceptanceTest.HookUp.Edit
{
    [Binding]
    public class EditCertificationsSteps
    {
        [Given(@"I have logged in and edit the certification sucessfully\.")]
        public void GivenIHaveLoggedInAndClickedOnCertificationTabSucessfully_()
        {
            SpecflowPages.Utils.ProfilePageCertification.EditCertification();
        }
        
     
        
        [Then(@"the updated skills should be shown on the list")]
        public void ThenTheUpdatedSkillsShouldBeShownOnTheList()
        {
            SpecflowPages.Utils.ProfilePageCertification.EditValidation();
        }
    }
}
