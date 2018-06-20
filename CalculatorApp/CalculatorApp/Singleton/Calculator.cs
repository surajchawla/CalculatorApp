using System;

namespace CalculatorApp
{
    public sealed class Calculator : ICalculator
    {
        private Operation _operation;

        private static readonly Lazy<Calculator> Lazy = new Lazy<Calculator>( () => new Calculator() );

        private Calculator()
        {
        }

        public static Calculator Instance
        {
            get { return Lazy.Value; }
        }

        public double Calculate(Operator operation, double leftOperand, double rightOperand)
        {
            switch (operation)
            {
                case Operator.ADD:
                    _operation = new Add(leftOperand, rightOperand);
                    break;

                case Operator.SUBTRACT:
                    _operation = new Subtract(leftOperand, rightOperand);
                    break;

                case Operator.DIVIDE:
                    _operation = new Divide(leftOperand, rightOperand);
                    break;

                case Operator.MULTIPLY:
                    _operation = new Multiply(leftOperand, rightOperand);
                    break;

                default:
                    throw new InvalidOperationException("Invalid Operator");
            }

            return _operation.Perform();
        }

        
    }
}