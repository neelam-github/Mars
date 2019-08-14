using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecflowTests.AcceptanceTest
{
    [Binding]
    public class SpecFlowFeature3Steps
    {
        [Given(@"I have logged into profile page sucessfully")]
        public void GivenIHaveLoggedIntoProfilePageSucessfully()
        {
            //wait
            Thread.Sleep(500);

            //Call the Login Class            
            SpecflowPages.Utils.LoginPage.LoginStep();
        }
        
        [When(@"I add a new Education")]
        public void WhenIAddANewEducation()
        {
            SpecflowPages.Utils.ProfilePageEducation.AddEducations();
        }
        
        [Then(@"that education should be displayed on my listing")]
        public void ThenThatEducationShouldBeDisplayedOnMyListing()
        {
            SpecflowPages.Utils.ProfilePageEducation.ValidateEducations();
        }
    }
}
