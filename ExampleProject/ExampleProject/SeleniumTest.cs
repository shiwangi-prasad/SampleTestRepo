using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace ExampleProject
{
    [TestFixture]
    public class SeleniumTest
    {
        [Test]
        public void Test()
        {
            IWebDriver webdriver = new FirefoxDriver();
            webdriver.Navigate().GoToUrl("http://google.com");
            IWebElement webElement = webdriver.FindElement(By.Id("gbqfq"));
            webElement.SendKeys("Selenium");
            webElement.Submit();
//            Assert.Contains();
        }
    }
}
