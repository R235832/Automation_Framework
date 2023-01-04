using EmployeeManagement.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Base

{
    public class LoginTest : AutomationWrapper
    {
        [Test]
        public void ValidLoginTest()
        {
            driver.FindElement(By.Name("username")).SendKeys("Admin");
            driver.FindElement(By.Name("password")).SendKeys("admin123");
            driver.FindElement(By.XPath(" //button[normalize-space()=\"Login\"]")).Click();
            string homePageLink = driver.Url;
            Assert.That(homePageLink, Is.EqualTo("https://opensource-demo.orangehrmlive.com/web/index.php/dashboard/index"));
        }
        public static object[] InvalidLoginData()
        {
            string[] dataSet1 = new string[3];//no of argument we have
            dataSet1[0] = "john";
            dataSet1[1] = "john123";
            dataSet1[2] = "Invalid credential";
            string[] dataSet2 = new string[3];
            dataSet2[0] = "peter";
            dataSet2[1] = "peter123";
            dataSet2[2] = "Invalid credential";
            string[] dataSet3 = new string[3];
            dataSet3[0] = "soul";
            dataSet3[1] = "soul123";
            dataSet3[2] = "Invalid credential";
            object[] allDataSet = new object[3];//number of test cases we have
            allDataSet[0] = dataSet1;
            allDataSet[1] = dataSet2;
            allDataSet[2] = dataSet3;

            return allDataSet;

        }
        [Test, TestCaseSource(nameof(InvalidLoginData))]

        //[Test]
        //[TestCase("john","john123", "Invalid credential")]
        //[TestCase("peter", "peter123", "Invalid credential")]
        public void InvalidLoginTest(string username,string password,string expectedError)
        {
            driver.FindElement(By.Name("username")).SendKeys(username);
            driver.FindElement(By.Name("password")).SendKeys(password);
            driver.FindElement(By.XPath("//button[normalize-space()='Login']")).Click();
            string actualError = driver.FindElement(By.XPath("//p[normalize-space()='Invalid credentials']")).Text;
            // Assert.That(actualError, Is.EqualTo("Invalid credentials"));
            Assert.That(actualError.Contains(expectedError), "Assertion on error message");
               
        }
    }
}
