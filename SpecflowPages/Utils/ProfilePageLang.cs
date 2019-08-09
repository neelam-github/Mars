using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SpecflowPages.CommonMethods;

namespace SpecflowPages.Utils
{
    public class ProfilePageLang
    {
        public static void AddLang()
        {
            // Click on Language tab.
            //Driver.driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]")).Click();
            //Click on Add New Button

            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div")).Click();
            //Enter the language
            Driver.driver.FindElement(By.XPath("//input[@name = 'name']")).SendKeys("English");
            //Select the language level.
            SelectElement select = new SelectElement(Driver.driver.FindElement(By.XPath("//select[@name ='level']")));
            select.SelectByText("Fluent");
            //Click on Add
            Driver.driver.FindElement(By.XPath("//input[@value='Add']")).Click();
        }

        //Validate the language is added sucessfully
        public static void ValidateLang()
        {
            string ExpectedValue = "English";
            string ActualValue = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]")).Text;
            if (ExpectedValue == ActualValue)
            {
                Console.WriteLine( "Test Passed, Added a Language Successfully");
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "LanguageAdded");
            }

            else
                Console.WriteLine("Test Failed, Language not added Successfully");
        }
    }
}
