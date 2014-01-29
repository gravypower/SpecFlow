using NUnit.Framework;
using TechTalk.SpecFlow;
using Tests.Spec.Drivers;

namespace Tests.Spec.Steps
{
    [Binding]
    public class CalculatorSteps
    {
        private ICalculatorDriver _calculatorDriver;

        [BeforeScenario("Real")]
        public void BeforeScenariosRealTag()
        {
            _calculatorDriver = new RealCalculatorDriver();
        }

        [BeforeScenario("Web")]
        public void BeforeScenariosWebTag()
        {
            _calculatorDriver = new WebCalculatorDriver();
        }

        [AfterScenario("Web")]
        public void AfterScenario()
        {
            _calculatorDriver.Dispose();
        }

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            _calculatorDriver.AddNumber(p0);
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            _calculatorDriver.PressAdd();
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Assert.That(_calculatorDriver.GetResult(), Is.EqualTo(p0));
        }

        [Then(@"the user is presented with an error message")]
        public void ThenTheUserIsPresentedWithAnErrorMessage()
        {
            Assert.That(_calculatorDriver.IsError(), Is.True);
            Assert.That(_calculatorDriver.GetErrorMessage(), Is.EqualTo("No numbers to add!"));
        }
    }
}
