using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecflowTests.AcceptanceTest
{
    [Binding]
    public class AddSkills
    {
        [Given(@"I have logged into profile page sucessfully")]
        public void GivenIHaveLoggedIntoProfilePageSucessfully()
        {
           //wait
            Thread.Sleep(500);

            //Call the Login Class            
            SpecflowPages.Utils.LoginPage.LoginStep();
        }
        
        
        [When(@"I click on the skill tab and add a new skill")]
        public void WhenIAddANewSkill()
        {
            SpecflowPages.Utils.ProfilePageSkills.AddSkills();
        }
        
        [Then(@"that skill should be displayed on my listing")]
        public void ThenThatSkillShouldBeDisplayedOnMyListing()
        {
            SpecflowPages.Utils.ProfilePageSkills.AddValidation();
        }
    }
}
