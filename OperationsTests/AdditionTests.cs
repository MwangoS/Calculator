﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Operations.Tests
{
    [TestClass()]
    public class AdditionTests
    {
        private readonly int a = 10;
        private readonly int b = 20;
        //private readonly double c = 10.5;
        //private readonly double d = 20.5;
        //private readonly double[] arrayA = { 1.01, 2.04, 3.06, 4.07, 5, 6, 7, 8, 9, 10 };
        //private readonly int[] arrayB = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        [TestMethod()]
        public void SumTest()
        {
            Assert.AreEqual(30, Addition.Sum(a, b));
        }
    }   
}