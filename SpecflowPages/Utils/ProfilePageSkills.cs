using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using RelevantCodes.ExtentReports;
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
            SelectElement select = new SelectElement(Driver.driver.FindElement(By.XPath("//select[@class ='ui fluid dropdown']")));
            select.SelectByText("Beginner");
            //Click Add
            Driver.driver.FindElement(By.XPath("//input[@class ='ui teal button ']")).Click();
        }

        public static void AddValidation()
        {
            string ExpectedValue = "Selenium";
            string ActualValue = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]")).Text;
            Thread.Sleep(2000);
            if (ExpectedValue == ActualValue)
            {
                Console.WriteLine("Test Passed, Added a Language Successfully");
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "SkillsAdded");
            }

            else
                Console.WriteLine("Test Failed, Skills not added Successfully");
        }

        public static void EditSKills()
        {
            //Wait
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            //Click on Skill Tab
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]")).Click();

            try
            {
                for (var i = 1; i <= 10; i++)
                {

                    var text = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]")).Text;
                    Console.WriteLine(text);
                    if (text == "Selenium")
                    {
                        //Wait
                        Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

                        //Click the edit button
                        Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[" + i + "]/tr/td[3]/span[1]/i")).Click();

                        //Clear the text and then write text
                        IWebElement SkillText = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[" + i + "]/tr/td/div/div[1]/input"));
                        SkillText.Clear();
                        SkillText.SendKeys("Networking");

                        //Click on the dropdown menu
                        Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[" + i + "]/tr/td/div/div[2]/select")).Click();


                        //Select the level
                        IWebElement SkillLevel = Driver.driver.FindElements(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[" + i + "]/tr/td/div/div[2]/select/option"))[1];
                        SkillLevel.Click();

                        //Click update 
                        Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[2]/tr/td/div/span/input[1]")).Click();

                    }

                }
            }
            catch (Exception)
            {
                Console.WriteLine("Test Failed");
            }
        }
        public static void EditValidation() { 

            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();

                Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

                CommonMethods.test = CommonMethods.extent.StartTest("Edit a Skill");

                Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

                string ExpectedValue = "Networking";
                string ActualValue = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[1]")).Text;

                Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Edited a Skill Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "SkillEdited");
                }

                else
                    CommonMethods.test.Log(LogStatus.Fail, "Test Failed");

            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }
        }

        public static void DeleteSkills()
        {
            //Wait
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            //Click on Skill Tab
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]")).Click();

            try
            {
                for (var i = 1; i <= 10; i++)
                {
                    var textcode = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]")).Text;
                    Console.WriteLine(textcode);
                    if (textcode == "Networking")
                    {
                        //Wait
                        Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

                        //Click the Delete button
                        Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[" + i + "]/tr/td[3]/span[2]/i")).Click();

                    }

                }
            }
            catch (Exception)
            {
                Console.WriteLine("Test Failed");
            }
        }

        public static void DeleteValidation() { 
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();

                Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

                CommonMethods.test = CommonMethods.extent.StartTest("Delete a Skill");

                Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

                string ExpectedValue = "Networking";
                string ActualValue = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]")).Text;

                Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

                if (!(ExpectedValue == ActualValue))
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Deleted a Skill Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "SkillDelete");
                }

                else
                    CommonMethods.test.Log(LogStatus.Fail, "Test Failed");

            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }


        }
    }
}
