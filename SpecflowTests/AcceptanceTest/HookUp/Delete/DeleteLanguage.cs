using System;
using TechTalk.SpecFlow;

namespace SpecflowTests.AcceptanceTest.HookUp.Delete
{
    [Binding]
    public class DeleteLanguage
    {
        [Given(@"I have logged in to the profile page and delete the language sucessfully")]
        public void GivenIHaveLoggedInSucessfullyToTheProfilePage()
        {
            SpecflowPages.Utils.ProfilePageLanguage.DeleteLang();
        }
        
        
        [Then(@"the respective language should be deleted")]
        public void ThenTheRespectiveLanguageShouldBeDeleted()
        {
            SpecflowPages.Utils.ProfilePageLanguage.DeleteValidation();
        }
    }
}
