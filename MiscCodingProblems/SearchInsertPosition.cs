using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscCodingProblems
{
    /// <summary>
    /// 35. Search Insert Position
    /// </summary>
    public class SearchInsertPosition
    {
        public int SearchInsert(int[] nums, int target)
        {
            if (!nums.Any() || target < nums[0]) return 0;
            if (target > nums.Last()) return nums.Length;
            var start = 0;
            var end = nums.Length - 1;
            while (start <= end)
            {
                var mid = start + (end- start) / 2;
                if (nums[mid] == target) return mid;
                else if (nums[mid] < target) start = mid + 1;
                else end = mid - 1;

            }

            return start;
        }
    }
}
