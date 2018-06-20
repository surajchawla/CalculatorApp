namespace CalculatorApp
{
    public abstract class Operation
    {
        protected double _leftOperand;
        protected double _rightOperand;

        public Operation(double leftOperand, double rightOperand)
        {
            _leftOperand = leftOperand;
            _rightOperand = rightOperand;            
        }

        public abstract double Perform();
    }
}