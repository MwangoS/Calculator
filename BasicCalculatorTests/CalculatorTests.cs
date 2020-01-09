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
        [TestMethod()]
        public void AddTest()
        {
            Calculator calculator = new Calculator();
            int c = calculator.Add(3, 4);
            Assert.AreEqual(7, c);
            Assert.AreEqual(7, calculator.result);
        }

        [TestMethod()]
        public void AddIntDoubleTest()
        {
            Calculator calculator = new Calculator();
            int a = 1;
            double b = 2.02;
            double c = calculator.Add(a, b);
            Assert.AreEqual(3.02, c);
            Assert.AreEqual(3.02, calculator.result);
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
        public void SubtractTest()
        {
            Calculator calculator = new Calculator();
            int d = calculator.Subtraction(15, 10);

            Assert.AreEqual(5, d);
            Assert.AreEqual(5, calculator.result);
        }

        [TestMethod()]
        public void SqaureTest()
        {
            Calculator calculator = new Calculator();
            int c = calculator.Squared(5);
            Assert.AreEqual(25, c);
            Assert.AreEqual(25, calculator.result);
        }
        //[TestMethod()]
       // public void MultiplyTest()
        //{
          //  Calculator calculator = new Calculator();
         //   int f = calculator.Multiplication(3, 2);
          //  Assert.AreEqual(6, f);
          //  Assert.AreEqual(6, calculator.result);
        //}
        
        //[TestMethod()]
        //public void QuotientIntDivideZeroTest()
        //{
        // Assert.ThrowsException<DivideByZeroException>(() => Division.Divide(a, c));
        //}



    }
}