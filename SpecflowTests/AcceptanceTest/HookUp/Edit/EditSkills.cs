using System;
using TechTalk.SpecFlow;

namespace SpecflowTests.AcceptanceTest.HookUp.Edit
{
    [Binding]
    public class EditSkillsSteps
    {
        [Given(@"I have logged in andedited the skills sucessfully")]
        public void GivenIHaveLoggedInAndClickedOnSkillsTabSucessfully()
        {
            SpecflowPages.Utils.ProfilePageSkills.EditSKills();
        }
        
      
        
        [Then(@"the updated skills shoukd be shown on the list")]
        public void ThenTheUpdatedSkillsShoukdBeShownOnTheList()
        {
            SpecflowPages.Utils.ProfilePageSkills.EditSKills();
        }
    }
}
