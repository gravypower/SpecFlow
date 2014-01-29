using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using Tests.Spec.Facades;

namespace Tests.Spec.Steps
{
    [Binding]
    public abstract class BaseCalculatorSteps
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
