using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MiscCodingProblems;

namespace MiscCodingProblemsTest
{
    [TestClass]
    public class BackspaceStringCompareTest
    {
        [TestMethod]
        public void StringMatchTest()
        {
            var comparer = new BackspaceStringCompare();
            var actualResult = comparer.GetResult("ab##", "c#d#");
            Assert.AreEqual(actualResult, true);
        }
    }
}
