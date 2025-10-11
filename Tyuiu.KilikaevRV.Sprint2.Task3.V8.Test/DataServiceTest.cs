
using Tyuiu.KilikaevRV.Sprint2.Task3.V8.Lib;
using System;

namespace Tyuiu.KilikaevRV.Sprint2.Task3.V8.Test
{
    [TestClass]
    public class FunctionCalculatorTests
    {
        [TestMethod]
        public void CalculateFunction_XIsZero_ReturnsCorrectValue()
        {
            double x = 0;
            double expected = Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2)) + 12;
            expected = Math.Round(expected, 3);

            double actual = FunctionCalculator.CalculateFunction(x);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateFunction_XPositiveLessThan5_ReturnsCorrectValue()
        {
            double x = 3;
            double expected = Math.Sin(x) + Math.Cos(x);
            expected = Math.Round(expected, 3);

            double actual = FunctionCalculator.CalculateFunction(x);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateFunction_XPositiveBetween5And10_ReturnsCorrectValue()
        {
            double x = 7;
            double expected = Math.Sin(x) - Math.Cos(x); // исправлено
            expected = Math.Round(expected, 3);

            double actual = FunctionCalculator.CalculateFunction(x);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateFunction_XPositiveGreaterOrEqual10_ReturnsCorrectValue()
        {
            double x = 12;
            double expected = Math.Pow(x, 2) - Math.Cos(Math.Pow(x, 2)) + 10;
            expected = Math.Round(expected, 3);

            double actual = FunctionCalculator.CalculateFunction(x);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateFunction_XNegativeGreaterThanMinus12_ReturnsCorrectValue()
        {
            double x = -5;
            double expected = 1 + (3 / Math.Pow(x, 2));
            expected = Math.Round(expected, 3);

            double actual = FunctionCalculator.CalculateFunction(x);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateFunction_XNegativeLessOrEqualMinus12_ReturnsCorrectValue()
        {
            double x = -15;
            double expected = x + 10 * x - (5 / x);
            expected = Math.Round(expected, 3);

            double actual = FunctionCalculator.CalculateFunction(x);

            Assert.AreEqual(expected, actual);
        }
    }
}