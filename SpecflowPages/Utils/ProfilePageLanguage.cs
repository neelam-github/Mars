using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SpecflowPages.CommonMethods;

namespace SpecflowPages.Utils
{
    public class ProfilePageLanguage
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
        public static void AddValidation()
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

        //Edit language
        public static void EditLang()
        {
            //Wait
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            // Click on Language tab
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]")).Click();

            try
            {
                for (var i = 1; i <= 10; i++)
                {
                    var text = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]")).Text;
                    Console.WriteLine(text);
                    if (text == "English")
                    {
                        //Wait
                        Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

                        //Click the edit button
                        Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[3]/span[1]/i")).Click();

                        //Clear the text and then write British English
                        IWebElement LangText = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td/div/div[1]/input"));
                        LangText.Clear();
                        LangText.SendKeys("British English");

                        //Click on the dropdown menu
                        Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td/div/div[2]/select")).Click();

                        //Select the level
                        IWebElement Level = Driver.driver.FindElements(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td/div/div[2]/select/option"))[4];
                        Level.Click();

                        //Click update
                        Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td/div/span/input[1]")).Click();

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

                CommonMethods.test = CommonMethods.extent.StartTest("Edit a Language");

                Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

                string ExpectedValue = "British English";
                string ActualValue = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]")).Text;

                Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Edited a Language Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "LanguageEdited");
                }

                else
                    CommonMethods.test.Log(LogStatus.Fail, "Test Failed");

            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }
        }

        public static void DeleteLang()
        {
            //Wait
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            // Click on Language tab
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]")).Click();

            try
            {
                for (var i = 1; i <= 10; i++)
                {
                    var text = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]")).Text;
                    Console.WriteLine(text);
                    if (text == "British English")
                    {
                        //Wait
                        Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

                        //Click the Delete button
                        Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[3]/span[2]/i")).Click();

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

                CommonMethods.test = CommonMethods.extent.StartTest("Delete a Language");

                Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

                string ExpectedValue = "British English";
                string ActualValue = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]")).Text;

                Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

                if (!(ExpectedValue == ActualValue))
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Deleted a Language Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "LanguageDelete");
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

    

