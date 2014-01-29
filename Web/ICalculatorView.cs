namespace Web
{
    public interface ICalculatorView
    {
        string FirstTextBoxClientId { get; }
        string SecondTextBoxClientId { get; }
        string ThirdTextBoxClientId { get; }
        string AddButtonClientId { get; }
        string ResultClientId { get; }
        string ErrorMessageClientId { get; }
    }
}
