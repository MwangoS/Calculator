using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Operations.Tests
{
    [TestClass()]
    public class MultiplicationTests
    {
        private readonly int a = 25;
        private readonly int b = 7;
        private readonly double c = 5.3;
        private readonly double d = 2.5;
        private readonly double[] arrayA = { 2, 6, 1, 4 }; 

        [TestMethod()]
        public void MultiplyTest()
        {
            Assert.AreEqual(175, Multiplication.Multiply(a, b));
        }

        [TestMethod()]
        public void MultiplyDoubleTest()
        {
            Assert.AreEqual(13.25, Multiplication.Multiply(c, d));
        }

        [TestMethod()]
        public void MultiplyDoubleArrayTest()
        {
            Assert.AreEqual(0, Multiplication.Multiply(arrayA));
        }
    }
}