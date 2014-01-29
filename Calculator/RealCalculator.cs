using System;

namespace Calculator
{
    public class RealCalculator : Calculator
    {
        public bool IsErrorMessage { get; private set; }
        public string ErrorMessage { get; private set; }
        public RealCalculator()
        {
            IsErrorMessage = false;
        }

        public new void Add()
        {
            try
            {
                base.Add();
            }
            catch (NoNumbersException)
            {
                IsErrorMessage = true;
                ErrorMessage = "No numbers to add!";
            }
        }
    }
}
