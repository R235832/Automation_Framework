using EmployeeManagement.Base;
using EmployeeManagement.Page;
using EmployeeManagement.Pages;
using EmployeeManagement.Utilities;
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
            MainPage urlclick = new MainPage(driver);
            LoginPage logindetails = new LoginPage(driver);
            logindetails.EnterUsername("Admin");
            logindetails.EnterPassword("admin123");
            logindetails.ClickOnLogin();
           
           

            //driver.FindElement(By.Name("username")).SendKeys("Admin");
            //driver.FindElement(By.Name("password")).SendKeys("admin123");
           // driver.FindElement(By.XPath(" //button[normalize-space()=\"Login\"]")).Click();
            string homePageLink = urlclick.GetManePageUrl();
            Assert.That(homePageLink, Is.EqualTo("https://opensource-demo.orangehrmlive.com/web/index.php/dashboard/index"));
        }
        
        [Test, TestCaseSource(typeof(DataSource),nameof(DataSource.InvalidLoginData2))]

        //[Test]
        //[TestCase("john","john123", "Invalid credential")]
        //[TestCase("peter", "peter123", "Invalid credential")]
        public void InvalidLoginTest(string username,string password,string expectedError)
        {

            LoginPage logindetails = new LoginPage(driver);
            logindetails.EnterUsername(username);
            logindetails.EnterPassword(password);
            logindetails.ClickOnLogin();
          
            logindetails.GetErrorMessage();


            //driver.FindElement(By.Name("username")).SendKeys(username);
            //driver.FindElement(By.Name("password")).SendKeys(password);
            //driver.FindElement(By.XPath("//button[normalize-space()='Login']")).Click();
            string actualError = logindetails.GetErrorMessage();
            // Assert.That(actualError, Is.EqualTo("Invalid credentials"));
            Assert.That(actualError.Contains(expectedError), "Assertion on error message");
               
        }
    }
}
