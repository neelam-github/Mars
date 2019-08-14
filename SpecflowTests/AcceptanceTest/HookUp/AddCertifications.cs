using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecflowTests.AcceptanceTest
{
    [Binding]
    public class SpecFlowFeature4Steps
    {
        [Given(@"I have logged into the profile page sucessfully")]
        public void GivenIHaveLoggedIntoTheProfilePageSucessfully()
        {
            //wait
            Thread.Sleep(500);

            //Call the Login Class            
            SpecflowPages.Utils.LoginPage.LoginStep();
        }
        
       
        
        [When(@"I click on the certification tab and add a new certification")]
        public void WhenIAddANewCertification()
        {
            SpecflowPages.Utils.ProfilePageCertification.AddCertifications();
        }
        
        [Then(@"that certification should be displayed on my listing\.")]
        public void ThenThatCertificationShouldBeDisplayedOnMyListing_()
        {
            SpecflowPages.Utils.ProfilePageCertification.ValidateCertifications();
        }
    }
}
