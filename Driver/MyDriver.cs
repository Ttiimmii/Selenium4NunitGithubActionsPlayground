using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium4.Driver
{
    public class MyDriver(OpenQA.Selenium.IWebDriver driver) : IWebDriver
    {
        private readonly OpenQA.Selenium.IWebDriver driver = driver;

        public string Url { get => driver.Url; set => driver.Url = value; }

        public string Title => driver.Title;

        public string PageSource => driver.PageSource;

        public string CurrentWindowHandle => driver.CurrentWindowHandle;

        public ReadOnlyCollection<string> WindowHandles => driver.WindowHandles;

        public void Close()
        {
            driver.Close();
        }

        public void Dispose()
        {
            driver.Dispose();
        }

        public OpenQA.Selenium.IWebElement FindElement(OpenQA.Selenium.By by)
        {
            return driver.FindElement(by);
        }

        public ReadOnlyCollection<OpenQA.Selenium.IWebElement> FindElements(OpenQA.Selenium.By by)
        {
            return driver.FindElements(by);
        }

        public OpenQA.Selenium.IOptions Manage()
        {
            return driver.Manage();
        }

        public OpenQA.Selenium.INavigation Navigate()
        {
            return driver.Navigate();
        }

        public void Quit()
        {
            driver.Quit();
        }

        public OpenQA.Selenium.ITargetLocator SwitchTo()
        {
            return driver.SwitchTo();
        }
    }
}
