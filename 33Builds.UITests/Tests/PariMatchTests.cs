using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;

namespace _33Builds.UITests.Tests
{
    [Trait("Category", "Applications")]
    public class PariMatchTests
    {
        private const string HomeUrl = "https://parimatch.com/";

        [Fact]
        public void OpenHomePage()
        {
            using IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(HomeUrl);
            driver.Manage().Window.Maximize();
            Assert.True(true);
        }
    }
}