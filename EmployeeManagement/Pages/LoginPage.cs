using DocumentFormat.OpenXml.Bibliography;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Page
{
    
   public class LoginPage
    {
        private By _usernameLocator = By.Name("username");
        private By _passwordLocator = By.Name("password");
        private By _clickOnLoginLocator = By.XPath(" //button[normalize-space()=\"Login\"]");
        private By _forgotpasswordLocator = By.XPath("//p[normalize-space()='Forgot your password?'] ");
        private By _errorLocator = By.XPath("//p[normalize-space()='Invalid credentials']");
        private IWebDriver driver;
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public  void EnterUsername(string username)
        {
            driver.FindElement(_usernameLocator).SendKeys(username);
        }
        public  void EnterPassword(string password)
        {

            driver.FindElement(_passwordLocator).SendKeys(password);
        }
        public void ClickOnLogin()
        {
            driver.FindElement(_clickOnLoginLocator).Click();
        }
        public void ForgotPassword()
        {
            driver.FindElement(_forgotpasswordLocator).Click();
        }
        public string GetErrorMessage()
        {
           return driver.FindElement(_errorLocator).Text;
        }
    }
}
