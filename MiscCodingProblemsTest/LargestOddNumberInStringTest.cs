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
    public class LargestOddNumberInStringTest
    {
        [TestMethod]
        public void Get_OddNumberInput_ReturnInput()
        {
            var oddFinder = new LargestOddNumberInString();
            var input = "35427";
            var actualResult = oddFinder.Get(input);

            Assert.AreEqual(input, actualResult);
        }
        [TestMethod]
        public void Get_OddNumberInTheStart_ReturnThatDigit()
        {
            var oddFinder = new LargestOddNumberInString();
            var input = "52";
            var expectedResult = "5";
            var actualResult = oddFinder.Get(input);

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Get_NoOddNumber_ReturnThatDigit()
        {
            var oddFinder = new LargestOddNumberInString();
            var input = "4206";
            var expectedResult = "";
            var actualResult = oddFinder.Get(input);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
