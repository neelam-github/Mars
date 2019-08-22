using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecflowTests.AcceptanceTest.HookUp
{
    [Binding]
    public class SpecFlowFeature1_1Steps
    {
        [When(@"I edit my language and/or language skills")]
        public void WhenIEditMyLanguageAndOrLanguageSkills()
        {
            
            SpecflowPages.Utils.ProfilePageLanguage.EditLang();
        }

      
        [Then(@"the updated records should be visible")]
        public void ThenTheUpdatedRecordsShouldBeVisible()
        {
            SpecflowPages.Utils.ProfilePageLanguage.EditValidation();
        }
    }
}
