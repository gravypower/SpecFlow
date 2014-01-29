using NUnit.Framework;
using TechTalk.SpecFlow;
using Tests.Spec.Facades;

namespace Tests.Spec.Steps
{
    [Binding]
    public class RealCalculatorSteps:Steps
    {
        [BeforeScenario("Real")]
        public void BeforeScenariosRealTag()
        {
            ScenarioContext.Current.Add("CalculatorFacade", new RealCalculatorFacade());
        }

        [Then(@"the user is presented with an error message")]
        public void ThenTheUserIsPresentedWithAnErrorMessage()
        {
            Assert.That(CalculatorFacade.IsError(), Is.True);
            Assert.That(CalculatorFacade.GetErrorMessage(), Is.EqualTo("No numbers to add!"));
        }
    }
}
