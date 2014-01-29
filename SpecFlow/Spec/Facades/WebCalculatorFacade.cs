using System.Globalization;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Tests.Spec.Pages;
using Web;

namespace Tests.Spec.Facades
{
    public class WebCalculatorFacade : Page, ICalculatorFacade
    {
        public ICalculatorView Calculator { get; set; }

        private IWebElement _currentTextBox;

        public WebCalculatorFacade()
        {
            WebDriver.Navigate().GoToUrl("http://SpecFlow/Calculator");
            Calculator = new Web.Calculator();
            _currentTextBox = GetControl(Calculator.FirstTextBoxClientId);

        }

        public void AddNumber(int number)
        {
            _currentTextBox.SendKeys(number.ToString(CultureInfo.InvariantCulture));

            _currentTextBox =
                GetControl(_currentTextBox.GetAttribute("ID") == Calculator.FirstTextBoxClientId
                    ? Calculator.SecondTextBoxClientId
                    : Calculator.ThirdTextBoxClientId);
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

        public bool ErrorMessageClassApplied()
        {
            return ControlHasClassApplied(Calculator.ErrorMessageClientId, "error");
        }
    }
}
