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
    public class ProfilePageEducation
    {

        public static void AddEducations()
        {
            //Click on the Education Tab
            Driver.driver.FindElement(By.XPath("//a[@data-tab ='third']")).Click();
            //Click on Add New
            Driver.driver.FindElement(By.XPath("//input[@class='ui teal button']")).Click();
            //Enter the institute detail
            Driver.driver.FindElement(By.XPath("//input[@name = 'instituteName']")).SendKeys("SIET");
            //Select the country
            SelectElement select = new SelectElement(Driver.driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select")));
            select.SelectByText("India");
            //Select Title
            SelectElement select1 = new SelectElement(Driver.driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select")));
            select1.SelectByText("B.Tech");
            //Enter degree
            Driver.driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input")).SendKeys("Electronics & Telecomm");
            //Select Year
            SelectElement select2 = new SelectElement(Driver.driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select")));
            select2.SelectByText("2008");
            //Click on Add
            Driver.driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]")).Click();

        }

    


        public static void ValidateEducations()
        {
            string ExpectedValue = "Electronics & Telecomm";

            String ActualValue = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[4]")).Text;
            if (ExpectedValue == ActualValue)
            {
                Console.WriteLine("Test Passed, Added a Language Successfully");
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "Education Added");
            }

            else
                Console.WriteLine("Test Failed, Education not added Successfully");
        }


    }

    }

