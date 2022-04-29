using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscCodingProblems
{
    /// <summary>
    /// 26. Remove Duplicates from Sorted Array
    /// </summary>
    public class RemoveDuplicatesfromSortedArray
    {
        public int RemoveDuplicates(int[] nums)
        {
            var index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != nums[index])
                {
                    nums[index++] = nums[i];
                }
            }

            return index++;

        }
    }
}
