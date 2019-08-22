using System;
using TechTalk.SpecFlow;

namespace SpecflowTests.AcceptanceTest.HookUp.Delete
{
    [Binding]
    public class DeleteEducationsSteps
    {
        [Given(@"I have logged in and deleted the education sucessfully")]
        public void GivenIHaveLoggedInAndClickedOnTheEducationTabSucessfully()
        {
            SpecflowPages.Utils.ProfilePageEducation.DeleteEducations();
        }
        
      
        
        [Then(@"the respective education should get deleted")]
        public void ThenTheRespectiveEducationShouldGetDeleted()
        {
            SpecflowPages.Utils.ProfilePageEducation.DeleteValidation();
        }
    }
}
