using NUnit.Framework;
using RelevantCodes.ExtentReports;
using SpecflowPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using static SpecflowPages.CommonMethods;

namespace SpecflowTests.Utils
{
    
    public class Start : Driver
    {
        [SetUp]
        public void LogIn()
        {
            //Launch the browser
            Initialize();
            Thread.Sleep(500);

            //Call the Login Class            
            SpecflowPages.Utils.LoginPage.LoginStep();         
                      
        }
        //Languages
       [Test]
        public void AddLanguages()
        {
            // call the profile page language class
            SpecflowPages.Utils.ProfilePageLanguage.AddLang();
            SpecflowPages.Utils.ProfilePageLanguage.AddValidation();
            
        }
        [Test]
        public void EditLanguages()
        {
            SpecflowPages.Utils.ProfilePageLanguage.EditLang();
            SpecflowPages.Utils.ProfilePageLanguage.EditValidation();
        }

        public void DeleteLanguages()
        {
            SpecflowPages.Utils.ProfilePageLanguage.DeleteLang();
            SpecflowPages.Utils.ProfilePageLanguage.DeleteValidation();
        }

        //Skills
        [Test]
        public void AddSkills()
        {
            // call the profile page skills class
            SpecflowPages.Utils.ProfilePageSkills.AddSkills();
            SpecflowPages.Utils.ProfilePageSkills.AddValidation();
        }
        public void EditSkills()
        {
            SpecflowPages.Utils.ProfilePageSkills.EditSKills();
            SpecflowPages.Utils.ProfilePageSkills.EditValidation();
        }

        public void DeleteSkills()
        {
            SpecflowPages.Utils.ProfilePageSkills.DeleteSkills();
            SpecflowPages.Utils.ProfilePageSkills.DeleteValidation();
        }
        //Educations
        [Test]
        public void AddEducations()
        {
            // call the profile page education class
            SpecflowPages.Utils.ProfilePageEducation.AddEducations();
            SpecflowPages.Utils.ProfilePageEducation.AddValidation();
        }
        public void EditEducations()
        {
            SpecflowPages.Utils.ProfilePageEducation.EditEducations();
            SpecflowPages.Utils.ProfilePageEducation.EditValidation();
        }

        public void DeleteEducations()
        {
            SpecflowPages.Utils.ProfilePageEducation.DeleteEducations();
            SpecflowPages.Utils.ProfilePageEducation.DeleteValidation();

        }
        //Certifications
        [Test]
        public void AddCertifications()
        {
            // call the profile page certification class
            SpecflowPages.Utils.ProfilePageCertification.AddCertifications();
            SpecflowPages.Utils.ProfilePageCertification.AddValidation();
        }
        [Test]
        public void EditCertifications()
        {
            SpecflowPages.Utils.ProfilePageCertification.EditCertification();
            SpecflowPages.Utils.ProfilePageCertification.EditValidation();
        }

        [Test]
        public void DeleteCertifications()
        {
            SpecflowPages.Utils.ProfilePageCertification.DeleteCertification();
            SpecflowPages.Utils.ProfilePageCertification.DeleteValidation();
        }

        [TearDown]
        public void TearDown()
        {
            Thread.Sleep(500);
            // Screenshot
            string img = SaveScreenShotClass.SaveScreenshot(Driver.driver, "Report");
            test.Log(LogStatus.Info, "Snapshot below: " + test.AddScreenCapture(img));

            // end test. (Reports)
            CommonMethods.extent.EndTest(CommonMethods.test);

            // calling Flush writes everything to the log file (Reports)
            CommonMethods.extent.Flush();

            //Close the browser
            Close();
        }

    }
}
