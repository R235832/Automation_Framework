using EmployeeManagement.Base;
using EmployeeManagement.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    
    public class EmployeeTest:AutomationWrapper
    {
        [Test,TestCaseSource(typeof(DataSource), nameof(DataSource.ValidEmployeeNameTest))]

        public void AddValidEmployee(string username,string password,string firstname,string middlename,string lastname,string employeename)
        {
            driver.FindElement(By.Name("username")).SendKeys(username);
            driver.FindElement(By.Name("password")).SendKeys(password);
            driver.FindElement(By.XPath("//button[normalize-space()=\"Login\"]")).Click();
            driver.FindElement(By.XPath("//a[@href='/web/index.php/pim/viewPimModule']")).Click();
            driver.FindElement(By.XPath("//a[normalize-space()='Add Employee']")).Click();
            driver.FindElement(By.Name("firstName")).SendKeys(firstname);
            driver.FindElement(By.Name("middleName")).SendKeys(middlename);
            driver.FindElement(By.Name("lastName")).SendKeys(lastname);
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();
            string realemployeename = driver.FindElement(By.CssSelector("[class='oxd-text oxd-text--h6 --strong']")).Text;
            realemployeename.ToCharArray();
            Assert.That(employeename.Contains(realemployeename), "Assert on error message");                                   
        }
    }
}
//h6[@class='oxd-text oxd-text--h6 --strong']