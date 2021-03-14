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
        [TestMethod()]
        public void SumTest()
        {
            Calculator calculator = new Calculator();
            double sum = calculator.Sum(3, 5);
            Assert.AreEqual<double>(8, sum);
        }
    }
}