using System;
using TechTalk.SpecFlow;

namespace SpecflowTests.AcceptanceTest.HookUp.Delete
{
    [Binding]
    public class DeleteCertificationsSteps
    {
        [Given(@"I have logged in and delete the certification sucessfully")]
        public void GivenIHaveLoggedInAndClickedOnTheCertificationTabSucessfully()
        {
            SpecflowPages.Utils.ProfilePageCertification.DeleteCertification();
        }
        
        [Then(@"the respective certification should be deleted")]
        public void ThenTheRespectiveCertificationShouldBeDeleted()
        {
            SpecflowPages.Utils.ProfilePageCertification.DeleteValidation();
        }
    }
}
