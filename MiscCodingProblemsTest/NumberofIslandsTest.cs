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
    public class NumberofIslandsTest
    {
        [TestMethod]
        public void NumIslandsTest()
        {
            
            char[,] grid = new char[,] { 
                { '1', '1', '1', '1', '0'}, 
                { '1', '1', '0', '1', '0'},
                { '1', '1', '0', '0', '0'},
                { '0', '0', '0', '0', '0'} };

            var numOfIsland = new NumberofIslands();
            var result = numOfIsland.NumIslands(grid);

            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void NumIslandsTest_JaggedArray()
        {
            //char[][] jaggedArray =
            //{
            //    new char[] { '1', '1', '1', '1', '0'},
            //    new char[] { '1', '1', '0', '1', '0'},
            //    new char[] { '1', '1', '0', '0', '0'},
            //    new char[] { '0', '0', '0', '0', '0'}
            //};
           
            char[][] jaggedArray =
            {
                new char[] { '1','1','0','0','0'},
                new char[] { '1','1','0','0','0'},
                new char[] { '0','0','1','0','0'},
                new char[] { '0', '0', '0', '1', '1' }
            };
           

            var numOfIsland = new NumberofIslands();
            var result = numOfIsland.NumIslands(jaggedArray);

            Assert.AreEqual(3, result);
        }
    }
}
