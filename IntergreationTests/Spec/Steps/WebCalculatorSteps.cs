﻿using IntergreationTests.Spec.Facades;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace IntergreationTests.Spec.Steps
{
    [Binding]
    public class WebCalculatorSteps : Tests.Spec.Steps.Steps
    {
        protected WebCalculatorFacade WebCalculatorFacade
        {
            get { return (WebCalculatorFacade) CalculatorFacade; }
        }
        [BeforeScenario("Web")]
        public void BeforeScenariosWebTag()
        {
            ScenarioContext.Current.Add("CalculatorFacade", new WebCalculatorFacade());
        }

        [AfterScenario("Web")]
        public void AfterScenario()
        {
            CalculatorFacade.Dispose();
        }

        [Then(@"the user is presented with an message with error class applyed")]
        public void ThenTheUserIsPresentedWithAnMessageWithErrorClassApplyed()
        {
            Assert.That(WebCalculatorFacade.ErrorMessageClassApplied(), Is.True);
        }

    }
}
