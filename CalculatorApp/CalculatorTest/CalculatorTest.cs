using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorApp;
using OperationsLibrary;

namespace CalculatorTest
{
    [TestClass]
    public class UnitTestForDivision
    {
        Operations op = new Operations();

        [TestMethod]
        public void TestDivideMethodForInvalidInput()
        {
            double numerator = 10;
            double denominator = 0;
            Assert.ThrowsException<DivideByZeroException>(() => op.Div(numerator, denominator));
        }

        [TestMethod]
        public void TestDivideMethodForValidInput()
        {
            double numerator = 10;
            double denominator = 2;
            double actual = op.Div(numerator, denominator);
            double expected = 5;
            Assert.AreEqual(expected, actual);
        }
    }

    [TestClass]
    public class UnitTestForMultiplication
    {
        Operations op1 = new Operations();

        [TestMethod]
        public void TestMultiplyMethodForInvalidInput()
        {
            Assert.ThrowsException<OverflowException>(() => op1.Multiply(6465465465465464, double.MaxValue));
        }

        [TestMethod]
        public void TestMultiplyMethodForValidInput()
        {
            double actual = op1.Multiply(10, 5);
            double expected = 50;
            Assert.AreEqual(expected, actual);
        }
    }
}
