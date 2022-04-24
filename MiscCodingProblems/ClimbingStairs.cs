using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscCodingProblems
{
    /// <summary>
    /// 70. Climbing Stairs
    /// </summary>
    public class ClimbingStairs
    {
        private Dictionary<int, int> combinatiosByStepNumber = new Dictionary<int, int>();
        public int GetClimbCombinations(int n)
        {
            return GetClimbCombinationsHelper(n);
        }

        private int GetClimbCombinationsHelper(int i)
        {
            int result = 0;
            if (combinatiosByStepNumber.ContainsKey(i)) return combinatiosByStepNumber[i];
            if (i == 1) return 1;
            if(i == 2) return 2;
            result = GetClimbCombinationsHelper(i - 1) + GetClimbCombinationsHelper(i - 2);
            combinatiosByStepNumber.Add(i, result);
            return result;

        }
    }
}
