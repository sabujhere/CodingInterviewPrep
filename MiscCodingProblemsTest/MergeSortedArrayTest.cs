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
    public class MergeSortedArrayTest
    {
        [TestMethod]
        public void GetSortedArray_EqualArraySize_ReturnsSortedArray()
        {
            var array1 = new[] { 1, 2, 3, };
            var array2 = new[] { 2, 4, 6 };

            var actualResult = new MergeSortedArray().GetSortedArray(array1, array2);

            Assert.IsTrue(Enumerable.SequenceEqual<int>(actualResult, new[] { 1, 2, 2, 3, 4, 6 }));

        }

        [TestMethod]
        public void GetSortedArray_Array1SizeGreaterThanArray2_ReturnsSortedArray()
        {
            var array1 = new[] { 1, 2, 3, 4, 6 };
            var array2 = new[] { 2 };

            var actualResult = new MergeSortedArray().GetSortedArray(array1, array2);

            Assert.IsTrue(Enumerable.SequenceEqual<int>(actualResult, new[] { 1, 2, 2, 3, 4, 6 }));

        }

        [TestMethod]
        public void GetSortedArray_Array2SizeGreaterThanArray1_ReturnsSortedArray()
        {
            var array1 = new[] { 1, 2 };
            var array2 = new[] { 2, 3, 4, 6 };

            var actualResult = new MergeSortedArray().GetSortedArray(array1, array2);

            Assert.IsTrue(Enumerable.SequenceEqual<int>(actualResult, new[] { 1, 2, 2, 3, 4, 6 }));

        }

        [TestMethod]
        public void GetSortedArray_Array2Empty_ReturnsArray1()
        {
            var array1 = new[] { 1, 2 };
            var array2 = Array.Empty<int>();

            var actualResult = new MergeSortedArray().GetSortedArray(array1, array2);

            Assert.IsTrue(Enumerable.SequenceEqual<int>(actualResult, new[] { 1, 2,}));
        }

        [TestMethod]
        public void GetSortedArray_Array1Empty_ReturnsArray2()
        {
            var array1 = Array.Empty<int>();
            var array2 = new[] { 1, 2 };

            var actualResult = new MergeSortedArray().GetSortedArray(array1, array2);

            Assert.IsTrue(Enumerable.SequenceEqual<int>(actualResult, new[] { 1, 2, }));
        }
    }
}
