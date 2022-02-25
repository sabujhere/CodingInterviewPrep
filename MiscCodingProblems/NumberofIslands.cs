using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscCodingProblems
{
    /// <summary>
    /// 200. Number of Islands
    /// </summary>
    public class NumberofIslands
    {
        public int NumIslands(char[,] grid)
        {
            var count = 0;
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    if (grid[i, j] == '1')
                    {
                        count++;
                        callBSF(grid, i, j);
                    }

                }
            }
            return count;
        }

        private void callBSF(char[,] grid, int i, int j)
        {
            if (grid.GetLength(0) < i || i < 0 || grid.GetLength(1) < j || j < 0 || grid[i, j] == '0') return;
            grid[i, j] = '0';
            callBSF(grid, i, j - 1);//left
            callBSF(grid, i, j + 1);//right
            callBSF(grid, i - 1, j);//up
            callBSF(grid, i + 1, j);//down
        }

        public int NumIslands(char[][] jaggedArray)
        {
            var count = 0;
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    if (jaggedArray[i][j] == '1')
                    {
                        count++;
                        callBSF(jaggedArray, i, j);
                    }

                }
            }
            return count;
        }
        private void callBSF(char[][] jaggedArray, int i, int j)
        {
            if (jaggedArray.Length <= i || i < 0 || jaggedArray[i].Length <= j || j < 0 || jaggedArray[i][j] == '0') return;
            jaggedArray[i][j] = '0';
            callBSF(jaggedArray, i - 1, j);//up
            callBSF(jaggedArray, i + 1, j);//down
            callBSF(jaggedArray, i, j - 1);//left
            callBSF(jaggedArray, i, j + 1);//right
        }
    }
}
