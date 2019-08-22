using System;
using TechTalk.SpecFlow;

namespace SpecflowTests.AcceptanceTest.HookUp.Delete
{
    [Binding]
    public class DeleteSkillsSteps
    {
        [Given(@"I have logged in and deleted the skills  sucessfully")]
        public void GivenIHaveLoggedInAndClickedOnTheSkillsTabSucessfully()
        {
            SpecflowPages.Utils.ProfilePageSkills.DeleteSkills();
        }
        
       
        [Then(@"the respective skills should be deleted")]
        public void ThenTheRespectiveSkillsShouldBeDeleted()
        {
            SpecflowPages.Utils.ProfilePageSkills.DeleteValidation();
        }
    }
}
