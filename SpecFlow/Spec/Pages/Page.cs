using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.PhantomJS;
using OpenQA.Selenium.Support.UI;

namespace Tests.Spec.Pages
{
    public abstract class Page
    {
        public IWebDriver WebDriver { get; set; }

        protected Page()
        {
#if DEBUG
            WebDriver = new PhantomJSDriver();
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
