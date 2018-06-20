using System;

namespace CalculatorApp
{
    public class Divide : Operation
    {
        public Divide(double leftOperand, double rightOperand) : base(leftOperand, rightOperand)
        {
        }

        public override double Perform()
        {
            try
            {
                var result = _leftOperand / _rightOperand;
                if (double.IsInfinity(result))
                {
                    throw new DivideByZeroException("Division by zero not allowed");
                }

                return result;
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}