namespace CalculatorApp
{
    public class UserCalculator : IUserCalculator
    {
        private ICalculator _calculator;

        public UserCalculator() : this(Calculator.Instance)
        {
        }

        public UserCalculator(ICalculator calculator)
        {
            _calculator = calculator;
        }
        
        public double PerformOperation(Operator oper, double leftOperand, double rightOperand)
        {
            return _calculator.Calculate(oper, leftOperand, rightOperand);
        }
    }
}