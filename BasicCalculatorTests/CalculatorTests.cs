using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicCalculator;
using System;
using System.Collections.Generic;
using System.Text;
using Operations;

namespace BasicCalculator.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        private readonly int a = 50;
        private readonly int c = 0;

        [TestMethod()]
        public void AddTest()
        {
            Calculator calculator = new Calculator();
            int c = calculator.Add(3, 4);
            Assert.AreEqual(7, c);
            Assert.AreEqual(7, calculator.result);
        }

        [TestMethod()]
        public void DivideTest()
        {
            Calculator calculator = new Calculator();


            int c = calculator.Divide(10, 2);


            Assert.AreEqual(5, c);
            Assert.AreEqual(5, calculator.result);
        }
        [TestMethod()]
        public void QuotientIntDivideZeroTest()
        {
            Assert.ThrowsException<DivideByZeroException>(() => Division.Divide(a, c));
        }



    }
}