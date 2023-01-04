using EmployeeManagement.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace EmployeeManagement.Base
{

    public class LoginUiTest : AutomationWrapper
    {

        [Test]

        public void ValidateTitleTest()
        {

            string actualtitle=driver.Title;
            Assert.That(actualtitle,Is.EqualTo("OrangeHRM"));
           
        }

        [Test]
        public void ValidatePlaceholderTest()
        {
             
           
            string actualUsernameResult= driver.FindElement(By.Name("username")).GetAttribute("placeholder");
            string actualPasswordResult = driver.FindElement(By.Name("password")).GetAttribute("placeholder");
            Assert.That(actualUsernameResult, Is.EqualTo("Username"));
            Assert.That(actualPasswordResult, Is.EqualTo("Password"));



        }
    }
}