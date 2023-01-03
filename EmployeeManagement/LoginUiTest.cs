using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace EmployeeManagement
{
    public class LoginUiTest
    {
        IWebDriver driver;
        [SetUp]
        public void AfterMethod()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = "https://opensource-demo.orangehrmlive.com/";
        }
        [TearDown]
        public void BeforeMethod()
        {
            driver.Quit();
        }

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