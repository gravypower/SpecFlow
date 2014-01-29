using System;

namespace Tests.Spec.Drivers
{
    public interface ICalculatorDriver : IDisposable
    {
        void AddNumber(int number);

        void PressAdd();
        int GetResult();

        string GetErrorMessage();
        bool IsError();
    }
}
