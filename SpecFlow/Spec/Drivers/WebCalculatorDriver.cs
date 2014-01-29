using System;
using System.Globalization;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Web;

namespace Tests.Spec.Drivers
{
    public class WebCalculatorDriver : ICalculatorDriver
    {
        public IWebDriver WebDriver { get; set; }
        public ICalculatorView Calculator { get; set; }

        private IWebElement _currentTextBox;


        public WebCalculatorDriver()
        {
            WebDriver = new ChromeDriver();
            WebDriver.Navigate().GoToUrl("http://SpecFlow/Calculator");
            Calculator = new Web.Calculator();
            _currentTextBox = GetControl(Calculator.FirstTextBoxClientId);
        }

        public void AddNumber(int number)
        {
            _currentTextBox.SendKeys(number.ToString(CultureInfo.InvariantCulture));

            if (_currentTextBox.GetAttribute("ID") == Calculator.FirstTextBoxClientId)
            {
                _currentTextBox = GetControl(Calculator.SecondTextBoxClientId);
            }
            else
            {
                _currentTextBox = GetControl(Calculator.ThirdTextBoxClientId);
            }
        }

        public void PressAdd()
        {
            var addButton = GetControl(Calculator.AddButtonClientId);
            addButton.Click();
        }

        public int GetResult()
        {
            var result = GetControl(Calculator.ResultClientId);
            return int.Parse(result.Text);
        }

        public string GetErrorMessage()
        {
            return GetControl(Calculator.ErrorMessageClientId).Text;
        }

        public bool IsError()
        {
            return !string.IsNullOrEmpty(GetErrorMessage());
        }


        private IWebElement GetControl(string clientId)
        {
            IWebElement control = null;

            try
            {
                var wait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(10));
                control =
                    wait.Until(
                        ExpectedConditions.ElementExists(
                            By.Id(clientId)));
            }
            catch
            {
            }

            return control;
        }

        public void Dispose()
        {
            WebDriver.Quit();
            WebDriver.Dispose();
        }
    }
}
