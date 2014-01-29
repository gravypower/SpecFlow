using NUnit.Framework;
using TechTalk.SpecFlow;
using Tests.Spec.Facades;

namespace Tests.Spec.Steps
{
    [Binding]
    public class CalculatorSteps:BaseCalculatorSteps
    {
        [BeforeScenario("Real")]
        public void BeforeScenariosRealTag()
        {
            ScenarioContext.Current.Add("CalculatorFacade", new RealCalculatorFacade());
        }

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            CalculatorFacade.AddNumber(p0);
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            CalculatorFacade.PressAdd();
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Assert.That(CalculatorFacade.GetResult(), Is.EqualTo(p0));
        }

        [Then(@"the user is presented with an error message")]
        public void ThenTheUserIsPresentedWithAnErrorMessage()
        {
            Assert.That(CalculatorFacade.IsError(), Is.True);
            Assert.That(CalculatorFacade.GetErrorMessage(), Is.EqualTo("No numbers to add!"));
        }
    }
}
