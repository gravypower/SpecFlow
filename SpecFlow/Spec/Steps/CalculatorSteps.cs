using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Tests.Spec.Steps
{
    [Binding]
    public class CalculatorSteps : Steps
    {
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
    }
}
