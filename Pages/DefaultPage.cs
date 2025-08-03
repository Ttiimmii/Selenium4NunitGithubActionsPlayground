using Selenium = OpenQA.Selenium;
using Selenium4.Driver;

namespace Selenium4.Pages
{
    public class DefaultPage(IWebDriver driver)
    {
        private readonly IWebDriver driver = driver;
        public Selenium.IWebElement Body => driver.FindElement(Selenium.By.TagName("body"));
    }
}
