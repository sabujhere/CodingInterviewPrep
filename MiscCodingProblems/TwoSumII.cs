using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscCodingProblems
{
    public class TwoSumII
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            var start = 0;
            var end = numbers.Length - 1;

            while(start < end)
            {
                var sum = numbers[start] + numbers[end];
                if(sum > target)
                {
                    end--;
                }
                else if(sum < target)
                {
                    start++;
                }
                else
                {
                    return new int[] { start+1, end+1 };
                }
            }

            return new int[] { start + 1, end + 1 };
        }
    }
}
