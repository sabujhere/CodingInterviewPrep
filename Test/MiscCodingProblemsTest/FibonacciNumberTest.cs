using Microsoft.VisualStudio.TestTools.UnitTesting;
using MiscCodingProblems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscCodingProblemsTest
{
    [TestClass]
    public class FibonacciNumberTest
    {
        [TestMethod]
        public void GetUsingRecursion_ReturnsValue()
        {
            var fibGenerator = new FibonacciNumber();
            var position = 10;
            var expectedNumber = 55;

            var actualResult = fibGenerator.GetUsingRecursion(position);

            Assert.AreEqual(expectedNumber, actualResult);
        }

        [TestMethod]
        public void GetUsingIteration_ReturnsValue()
        {
            var fibGenerator = new FibonacciNumber();
            var position = 10;
            var expectedNumber = 55;

            var actualResult = fibGenerator.GetUsingIteration(position);

            Assert.AreEqual(expectedNumber, actualResult);
        }
    }
}
