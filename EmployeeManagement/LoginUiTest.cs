using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace EmployeeManagement
{
    public class LoginUiTest
    {
        [Test]
        public void ValidateTitleTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(30);
            driver.Url = "https://opensource-demo.orangehrmlive.com/";
            string actualtitle=driver.Title;
            Assert.That(actualtitle,Is.EqualTo("OrangeHRM"));
           // Console.WriteLine(actualtitle); 
        }
    }
}