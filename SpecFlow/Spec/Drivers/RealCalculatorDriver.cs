using Calculator;

namespace Tests.Spec.Drivers
{
    public class RealCalculatorDriver : ICalculatorDriver
    {
        public RealCalculator Calculator { get; set; }

        public RealCalculatorDriver()
        {
            Calculator = new RealCalculator();
        }

        public void AddNumber(int number)
        {
            Calculator.Numbers.Add(number);
        }

        public void PressAdd()
        {
            Calculator.Add();
        }

        public int GetResult()
        {
            return Calculator.Result;
        }

        public string GetErrorMessage()
        {
            return Calculator.ErrorMessage;
        }

        public bool IsError()
        {
            return Calculator.IsErrorMessage;
        }

        public void Dispose()
        {
        }
    }
}
