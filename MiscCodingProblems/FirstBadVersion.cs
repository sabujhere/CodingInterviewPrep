using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscCodingProblems
{
    /// <summary>
    /// 278. First Bad Version
    /// </summary>
    public class FirstBadVersion
    {
        public int GetSolution(int n)
        {
            var left = 0;
            var right = n;
            while (left < right)
            {
                var middle = left + (right - left) / 2;
                if (IsBadVersion(middle))
                {
                    
                    right = middle;
                }
                else
                {
                    left = middle + 1;
                }
            }

            if (left == right && IsBadVersion(left)) return left;
            return -1;
        }
        /// <summary>
        /// This is a dummy function
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public bool IsBadVersion(int number)
        {
            return false;
        }
    }
}
