using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscCodingProblems
{
    /// <summary>
    /// 304. Range Sum Query 2D - Immutable
    /// </summary>
    public class RangeSumQuery2DImmutable
    {
        private int[][] calculatedMatrix;
        public RangeSumQuery2DImmutable(int[][] matrix)
        {
            var row = 0;
            var col = 0;
            if (matrix.Length != 0)
            {
                row = matrix.Length;
                col = matrix[0].Length;
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 1; j < matrix[0].Length; j++)
                {
                    matrix[i][j] += matrix[i][j - 1];
                }
            }
            for (int i = 1; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    matrix[i][j] += matrix[i-1][j];
                }
            }

            this.calculatedMatrix = matrix;
        }

        public int SumRegion(int row1, int col1, int row2, int col2)
        {
            return calculatedMatrix[row2][col2] - (row1 != 0 ? calculatedMatrix[row1 - 1][col2] : 0) - (col1 != 0 ? calculatedMatrix[row2][col1 - 1] : 0) + ((row1 != 0 && col1 != 0) ? calculatedMatrix[row1 - 1][col1 - 1] : 0);
        }
    }
}
