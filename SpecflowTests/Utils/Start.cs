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
       [Test]
        public void Feature1()
        {
            // call the profile page language class
            SpecflowPages.Utils.ProfilePageLang.AddLang();
            SpecflowPages.Utils.ProfilePageLang.ValidateLang();
        }
        [Test]
        public void Feature2()
        {
            // call the profile page skills class
            SpecflowPages.Utils.ProfilePageSkills.AddSkills();
            SpecflowPages.Utils.ProfilePageSkills.ValidateSkills();
        }
        [Test]
        public void Feature3()
        {
            // call the profile page education class
            SpecflowPages.Utils.ProfilePageEducation.AddEducations();
            SpecflowPages.Utils.ProfilePageEducation.ValidateEducations();
        }
        [Test]
        public void Feature4()
        {
            // call the profile page certification class
            SpecflowPages.Utils.ProfilePageCertification.AddCertifications();
            SpecflowPages.Utils.ProfilePageCertification.ValidateCertifications();
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
