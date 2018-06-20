using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace CalculatorApp.UnitTest
{
    [TestClass]
    public class CalculatorTest
    {
        Mock<ICalculator> _calculatorMock = new Mock<ICalculator>();
        private IUserCalculator _userCalculator;
        
        
        [TestMethod]
        public void TestAdd()
        {
            _userCalculator = new UserCalculator();
            double leftOperand = 35;
            double rightOperand = 5;

            Assert.AreEqual(40, _userCalculator.PerformOperation(Operator.ADD, leftOperand, rightOperand));
        }

        [TestMethod]
        public void TestSubtract()
        {
            _userCalculator = new UserCalculator();
            double leftOperand = 35;
            double rightOperand = 5;

            Assert.AreEqual(30, _userCalculator.PerformOperation(Operator.SUBTRACT, leftOperand, rightOperand));
        }

        [TestMethod]
        public void TestMultiply()
        {
            _userCalculator = new UserCalculator();
            double leftOperand = 35;
            double rightOperand = 5;

            Assert.AreEqual(175, _userCalculator.PerformOperation(Operator.MULTIPLY, leftOperand, rightOperand));
        }

        [TestMethod]
        public void TestDivide()
        {
            _userCalculator = new UserCalculator();
            double leftOperand = 35;
            double rightOperand = 5;

            Assert.AreEqual(7, _userCalculator.PerformOperation(Operator.DIVIDE, leftOperand, rightOperand));
        }

        [TestMethod]
        public void TestDivideByZero()
        {
            _userCalculator = new UserCalculator();
            double leftOperand = 35;
            double rightOperand = 0;

            Assert.ThrowsException<DivideByZeroException>( () => _userCalculator.PerformOperation(Operator.DIVIDE, leftOperand, rightOperand));
        }

        [TestMethod]
        public void TestArithmaticOverflowAddition()
        {
            _userCalculator = new UserCalculator();
            double leftOperand = Double.MaxValue;
            double rightOperand = Double.MaxValue;

            Assert.ThrowsException<ArithmeticException>(() => _userCalculator.PerformOperation(Operator.ADD, leftOperand, rightOperand));
        }

        [TestMethod]
        public void TestArithmaticOverflowSubtraction()
        {
            _userCalculator = new UserCalculator();
            double leftOperand = Double.MinValue;
            double rightOperand = Double.MaxValue;

            Assert.ThrowsException<ArithmeticException>(() => _userCalculator.PerformOperation(Operator.SUBTRACT, leftOperand, rightOperand));
        }

        [TestMethod]
        public void TestArithmaticOverflowMultiplication()
        {
            _userCalculator = new UserCalculator();
            double leftOperand = Double.MaxValue;
            double rightOperand = Double.MaxValue;

            Assert.ThrowsException<ArithmeticException>(() => _userCalculator.PerformOperation(Operator.MULTIPLY, leftOperand, rightOperand));
        }
    }
}
