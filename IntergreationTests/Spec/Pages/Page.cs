using System;
using OpenQA.Selenium;
using OpenQA.Selenium.PhantomJS;
using OpenQA.Selenium.Support.UI;

namespace IntergreationTests.Spec.Pages
{
    public abstract class Page
    {
        public IWebDriver WebDriver { get; set; }

        protected Page()
        {
#if DEBUG
            WebDriver = new PhantomJSDriver(@"C:\Apps\phantomjs-1.9.7-windows");
#else
            WebDriver = new ChromeDriver();
#endif
        }

        protected IWebElement GetControl(string clientId)
        {
            var wait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(10));
            var control = wait.Until(
                ExpectedConditions.ElementExists(
                    By.Id(clientId)));

            return control;
        }

        protected bool ControlHasClassApplied(string clientId, string className)
        {
            var wait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(10));
            var control = wait.Until(
                ExpectedConditions.ElementExists(
                    By.Id(clientId)));

            return control.GetAttribute("class") == className;

        }

        public void Dispose()
        {
            WebDriver.Quit();
            WebDriver.Dispose();
        }
    }
}
