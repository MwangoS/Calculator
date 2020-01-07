using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Operations.Tests
{
    [TestClass()]
    public class SubtractionTests
    {
        private readonly int a = 100;
        private readonly int b = 30;
        private readonly double e = 100.10;
        private readonly double f = 30.5;
        private readonly double[] arrayA = { 1.20, 2.04, 3.05, 4.0, };
        private readonly int[] arrayB = { 1, 2, 5, 6, };

        [TestMethod()]
        public void SubtractTest()
        {          
            Assert.AreEqual(70, Subtraction.Subtract(a, b));
        }
        [TestMethod()]
        public void SubtractDoubleTest()
        {            
            Assert.AreEqual(69.6, Subtraction.Subtract(e, f));
        }

        [TestMethod()]
        public void SubtractDoubleArrayTest()
        {            
            Assert.AreEqual(-10.29, Subtraction.Subtract(arrayA));
        }
        [TestMethod()]
        public void SubtractIntArrayTest()
        {
            Assert.AreEqual(-12, Subtraction.Subtract(arrayB));
        }
    }
}