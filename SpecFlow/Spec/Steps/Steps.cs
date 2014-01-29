using TechTalk.SpecFlow;
using Tests.Spec.Facades;

namespace Tests.Spec.Steps
{
    [Binding]
    public abstract class Steps
    {
        protected ICalculatorFacade CalculatorFacade
        {
            get
            {
                return (ICalculatorFacade)ScenarioContext.Current["CalculatorFacade"];
            }
        }
    }
}
