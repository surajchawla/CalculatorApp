namespace CalculatorApp
{
    public interface ICalculator
    {
        double Calculate(Operator operation, double leftOperand, double rightOperand);
    }
}