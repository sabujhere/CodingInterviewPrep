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
    public class RemoveAllOccurrencesOfASubstringTest
    {
        [TestMethod]
        public void Remove_ThreeCharPart_ReturnValue()
        {
            var strRemover = new RemoveAllOccurrencesOfASubstring();
            var s = "daabcbaabcbc";
            var part = "abc";
            var expectedResult = "dab";
            var actualResult = strRemover.Remove(s, part);
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void Remove_TwoCharPart_ReturnValue()
        {
            var strRemover = new RemoveAllOccurrencesOfASubstring();
            var s = "axxxxyyyyb";
            var part = "xy";
            var expectedResult = "ab";
            var actualResult = strRemover.Remove(s, part);
            Assert.AreEqual(expectedResult, actualResult);

        }

    }
}
