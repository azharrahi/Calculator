using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [DataTestMethod]
        [DataRow(3,4, 7)]
        [DataRow(5, 14, 19)]
        [DataRow(10, 15, 25)]
        [TestMethod()]
        public void SumTest(int x, int y, int expected)
        {
            Calculator calculator = new Calculator();
            double sum = calculator.Sum(x, y);
            Assert.AreEqual<double>(expected, sum);
        }

        [DataTestMethod]
        [DataRow(3, 4, -1)]
        [DataRow(15, 14, 1)]
        [DataRow(20, 15, 5)]
        [TestMethod()]
        public void SubtractTest(int x, int y, int expected)
        {
            Calculator calculator = new Calculator();
            double sum = calculator.Sum(x, y);
            Assert.AreEqual<double>(expected, sum);
        }
    }
}