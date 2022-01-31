using Microsoft.VisualStudio.TestTools.UnitTesting;
using SlidingWindowsForStrings;

namespace SlidingWindowsForStringsTest
{
    [TestClass]
    public class MinimumWindowSubstringTest
    {
        [TestMethod]
        public void MatchPatternWindowSubstring()
        {
            var str = "ADOBECODEBANC";
            var pattern = "ABC";
            var expectedResult = "BANC";
            var minWindow = new MinimumWindowSubstring();

            var result = minWindow.GetSubString(str, pattern);

            Assert.AreEqual(expectedResult, result);
        }
    }
}