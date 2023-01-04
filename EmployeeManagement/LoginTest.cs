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
        [Test]
        [TestCase("john","john123", "Invalid credential")]
        [TestCase("peter", "peter123", "Invalid credential")]
        public void InvalidLoginTest(string username,string password,string expectedError)
        {
            driver.FindElement(By.Name("username")).SendKeys(username);
            driver.FindElement(By.Name("password")).SendKeys(password);
            driver.FindElement(By.XPath(" //button[normalize-space()=\"Login\"]")).Click();
            string actualError = driver.FindElement(By.XPath("//p[normalize-space()='Invalid credentials']")).Text;
            // Assert.That(actualError, Is.EqualTo("Invalid credentials"));
            Assert.That(actualError.Contains(expectedError), "Assertion on error message");
               
        }
    }
}
