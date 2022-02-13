using Microsoft.VisualStudio.TestTools.UnitTesting;
using MiscCodingProblems;

namespace MiscCodingProblemsTest
{
    [TestClass]
    public class HasPairWithSumNaiveTest
    {
        [TestMethod]
        public void GetSumNaive_SumExists_ReturnsTrue()
        {
            var data = new[] { 1, 2, 4, 4 };
            var sum = 8;

            var actualResult = new HasPairWithSum().GetSumNaive(data, sum);

            Assert.IsTrue(actualResult,"The sum should have been found");

        }
        [TestMethod]
        public void GetSumNaive_SumExists_ReturnsFalse()
        {
            var data = new[] { 1, 2, 3, 9 };
            var sum = 8;

            var actualResult = new HasPairWithSum().GetSumNaive(data, sum);

            Assert.IsFalse(actualResult);

        }

        [TestMethod]
        public void GetSumBetter_SumExists_ReturnsTrue()
        {
            var data = new[] { 1, 2, 4, 4 };
            var sum = 8;

            var actualResult = new HasPairWithSum().GetSumBetter(data, sum);

            Assert.IsTrue(actualResult, "The sum should have been found");

        }
        [TestMethod]
        public void GetSumBetter_SumExists_ReturnsFalse()
        {
            var data = new[] { 1, 2, 3, 9 };
            var sum = 8;

            var actualResult = new HasPairWithSum().GetSumBetter(data, sum);

            Assert.IsFalse(actualResult);

        }
    }
}