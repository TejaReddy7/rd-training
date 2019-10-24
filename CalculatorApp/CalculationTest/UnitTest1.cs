using Microsoft.VisualStudio.TestTools.UnitTesting;
using OperationsLibrary;
using CalculatorApp;
using System;
using Moq;

namespace CalculationTest
{
    [TestClass]
    public class UnitTestForValidInputs
    {
        [TestMethod]
        [DataTestMethod]
        [DataRow(1, 1, 0)]
        [DataRow(-1, -1, 2)]
        [DataRow(0, 0, 0)]
        [DataRow(0, 0, 5)]
        public void TestSubtraction(double a, double b, double expected)
        {
            Mock<IOperations> mockobj = new Mock<IOperations>();
            mockobj.Setup(x => x.Sub(a, b)).Returns(expected);
            double result = mockobj.Object.Sub(a, b);
            Assert.AreEqual(result, expected);

        }

        [TestMethod]
        [DataTestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(-1, -1, 0)]
        [DataRow(0, 0, 0)]
        [DataRow(0, 0, 5)]
        public void TestAddition(double a, double b, double expected)
        {
            Mock<IOperations> mockobj = new Mock<IOperations>();
            mockobj.Setup(x => x.Add(a, b)).Returns(expected);
            double result = mockobj.Object.Add(a, b);
            Assert.AreEqual(result, expected);

        }

        Operations op = new Operations();

        [TestMethod]
        public void TestMultiply()
        {
            double actual = op.Multiply(10, 5);
            double expected = 50;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDivide()
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
        public void TestMultiply()
        {
            Assert.ThrowsException<OverflowException>(() => op1.Multiply(Double.MaxValue, Double.MaxValue));
        }

        

        [TestMethod]
        public void TestDivide()
        {
            double numerator = 10;
            double denominator = 0;
            Assert.ThrowsException<DivideByZeroException>(() => op1.Div(numerator, denominator));
        }
    }


}
