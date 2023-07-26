using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Test.UnitTest
{
    [TestFixture]
    public class BaseTest
    {
        protected IWebDriver Driver;
        private readonly string _baseUrl = "https://the-internet.herokuapp.com/javascript_alerts";
        
        [SetUp]
        public void SetUp()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl(_baseUrl);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}