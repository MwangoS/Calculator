using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatisticsCalculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatisticsCalculator.Tests
{
    [TestClass()]
    public class StatisticsCalculatorTests
    {
        [TestMethod()]
        public void MeanTest()
        {
            StatisticsCalculator statsCal = new StatisticsCalculator();
            int[] values = { 1, 2, 3 };
            var mean = statsCal.Mean(values);
            Assert.AreEqual(1.5, mean);
        }
    }
}