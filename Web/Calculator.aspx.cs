using System;
using System.Globalization;
using System.Web.UI;
using System.Web.UI.WebControls;
using Calculator;

namespace Web
{
    public partial class Calculator : Page, ICalculatorView
    {
        private RealCalculator _calculator;
        protected void Page_Load(object sender, EventArgs e)
        {
            _calculator = new RealCalculator();
        }

        protected void butAddNumbers_Click(object sender, EventArgs e)
        {
            AddTextBoxNumberToCalculator(txtFirstNumber);
            AddTextBoxNumberToCalculator(txtSecondNumber);
            AddTextBoxNumberToCalculator(txtThirdNumber);
           
            _calculator.Add();
            if (_calculator.IsErrorMessage)
            {
                lblErrorMessage.Text = _calculator.ErrorMessage;
            }
            else
            {
                lblResult.Text = _calculator.Result.ToString(CultureInfo.InvariantCulture);
            }
        }

        private void AddTextBoxNumberToCalculator(TextBox textBox)
        {
            if (!string.IsNullOrEmpty(textBox.Text))
            {
                _calculator.Numbers.Add(int.Parse(textBox.Text));
            }
        }

        public string FirstTextBoxClientId
        {
            get { return "MainContent_txtFirstNumber"; }
        }

        public string SecondTextBoxClientId
        {
            get { return "MainContent_txtSecondNumber"; }
        }

        public string ThirdTextBoxClientId
        {
            get { return "MainContent_txtThirdNumber"; }
        }


        public string AddButtonClientId
        {
            get { return "MainContent_butAddNumbers"; }
        }
        
        public string ResultClientId
        {
            get { return "MainContent_lblResult"; }
        }
        
        public string ErrorMessageClientId
        {
            get { return "MainContent_lblErrorMessage"; }
        }
    }
}