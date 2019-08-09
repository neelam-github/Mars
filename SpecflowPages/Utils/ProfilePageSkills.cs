using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static SpecflowPages.CommonMethods;

namespace SpecflowPages.Utils
{
    public class ProfilePageSkills
    {

        public static void AddSkills()
        {

            //Validate the page
            //Validate the page
            //String myTitle1 = Driver.driver.Title;
            //Console.WriteLine(myTitle1);
           // Assert.That(myTitle1, Is.EqualTo("Profile"));

            // Click on Skills tab
            // Driver.driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]")).Click();
            Driver.driver.FindElement(By.XPath("//a[@data-tab='second']")).Click();
            // Click on Add New
            //Driver.driver.FindElement(By.XPath("//input[@class='ui teal button']")).Click();
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div")).Click();
            Thread.Sleep(2000);
            //Add the skill in the text field
            // Driver.driver.FindElement(By.XPath("//*[@id='account -profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input")).SendKeys("Selenium");
            Driver.driver.FindElement(By.XPath("//input[@placeholder = 'Add Skill']")).SendKeys("Selenium");
            //Choose the skill level from the dropdown
            SelectElement select = new SelectElement(Driver.driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select")));
            select.SelectByText("Beginner");
            //Click Add
            Driver.driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]")).Click();
        }

        public static void ValidateSkills()
        {
            string ExpectedValue = "Selenium";
            string ActualValue = Driver.driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]")).Text;
            if (ExpectedValue == ActualValue)
            {
                Console.WriteLine("Test Passed, Added a Language Successfully");
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "SkillsAdded");
            }

            else
                Console.WriteLine("Test Failed, Skills not added Successfully");
        }
    
    }
}
