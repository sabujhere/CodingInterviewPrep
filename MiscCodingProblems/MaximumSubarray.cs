using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscCodingProblems
{
    /// <summary>
    /// 53. Maximum Subarray
    /// </summary>
    public class MaximumSubarray
    {
        public int MaxSubArray(int[] nums)
        {
            var currentSum = 0;
            var maxSum = nums[0];
            foreach (var num in nums)
            {

                if (currentSum < 0) currentSum = 0;
                currentSum = currentSum + num;
                maxSum = Math.Max(currentSum, maxSum);
            }
            return maxSum;


        }
    }
}
