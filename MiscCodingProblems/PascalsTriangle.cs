using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscCodingProblems
{

    /// <summary>
    /// 118. Pascal's Triangle
    /// </summary>
    public class PascalsTriangle
    {
        public IList<IList<int>> Generate(int numRows)
        {
            var result = new List<IList<int>>();
            result.Add(new List<int>() { 1 });
            for (int i = 1; i < numRows; i++)
            {
                result.Add(new List<int>() { 1 });
                for (int j = 1; j < i; j++)
                {
                    result[i].Add(result[i - 1][j - 1] + result[i - 1][j]);
                }
                result[i].Add(1);

            }

            return result;
        }
    }
}
