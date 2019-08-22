using System;
using TechTalk.SpecFlow;

namespace SpecflowTests.AcceptanceTest.HookUp.Edit
{
    [Binding]
    public class EditEducations
    {
        [Given(@"I have logged in and edit the education sucessfully")]
        public void GivenIHaveLoggedInAndClickedOnEducationTabSucessfully()
        {
            SpecflowPages.Utils.ProfilePageEducation.EditEducations();
        }
        
       
        
        [Then(@"I would able to see the updated details in my list\.")]
        public void ThenIWouldAbleToSeeTheUpdatedDetailsInMyList_()
        {
            SpecflowPages.Utils.ProfilePageEducation.EditValidation();
        }
    }
}
