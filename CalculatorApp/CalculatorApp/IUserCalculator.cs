namespace CalculatorApp
{
    public interface IUserCalculator
    {
        double PerformOperation(Operator oper, double leftOperand, double rightOperand);
    }
}