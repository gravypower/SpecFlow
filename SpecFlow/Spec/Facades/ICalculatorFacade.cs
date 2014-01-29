using System;

namespace Tests.Spec.Facades
{
    public interface ICalculatorFacade : IDisposable
    {
        void AddNumber(int number);

        void PressAdd();
        int GetResult();

        string GetErrorMessage();
        bool IsError();
    }
}
