using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator
{
    public abstract class Calculator
    {
        public List<int> Numbers { get; set; }
        public int Result { get; set; }

        protected Calculator()
        {
            Numbers = new List<int>();
        }

        public void Add()
        {
            if(!Numbers.Any())
                throw  new NoNumbersException();

            Result = Numbers.Sum();
        }

        [Serializable]
        public class NoNumbersException : Exception
        {
        }
    }
}
