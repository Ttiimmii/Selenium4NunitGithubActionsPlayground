using OpenQA.Selenium.Chrome;
using Selenium4.Driver;
using Selenium4.Pages;

namespace Selenium4Nunit
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            var driver = new MyDriver(new ChromeDriver());
            driver.Navigate().GoToUrl("https://www.ag-grid.com/example/");
            var defaultPage = new DefaultPage(driver);
            Thread.Sleep(5000);
            driver.Quit();
        }
    }
}