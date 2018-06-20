using System;

namespace CalculatorApp
{
    public class Multiply : Operation
    {
        public Multiply(double leftOperand, double rightOperand) : base(leftOperand, rightOperand)
        {
        }
        public override double Perform()
        {            
            try
            {
                var result =  _leftOperand * _rightOperand;
                if (double.IsInfinity(result))
                {
                    throw new ArithmeticException("Double value overflow");
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