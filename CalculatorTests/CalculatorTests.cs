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
        [DataRow(3,4, 6)]
        [TestMethod()]
        public void SumTest(int x, int y, int expected)
        {
            Calculator calculator = new Calculator();
            double sum = calculator.Sum(x, y);
            Assert.AreEqual<double>(expected, sum);
        }
    }
}