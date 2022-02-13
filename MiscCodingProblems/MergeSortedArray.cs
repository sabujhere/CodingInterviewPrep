using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscCodingProblems
{
    /*
     * 88. Merge Sorted Array
             * You are given two integer arrays nums1 and nums2, sorted in non-decreasing order, and two integers m and n, representing the number of elements in nums1 and nums2 respectively.

        Merge nums1 and nums2 into a single array sorted in non-decreasing order.

        The final sorted array should not be returned by the function, but instead be stored inside the array nums1. To accommodate this, nums1 has a length of m + n, where the first m elements denote the elements that should be merged, and the last n elements are set to 0 and should be ignored. nums2 has a length of n.

 

        Example 1:

        Input: nums1 = [1,2,3,0,0,0], m = 3, nums2 = [2,5,6], n = 3
        Output: [1,2,2,3,5,6]
        Explanation: The arrays we are merging are [1,2,3] and [2,5,6].
        The result of the merge is [1,2,2,3,5,6] with the underlined elements coming from nums1.
        Example 2:

        Input: nums1 = [1], m = 1, nums2 = [], n = 0
        Output: [1]
        Explanation: The arrays we are merging are [1] and [].
        The result of the merge is [1].
        Example 3:

        Input: nums1 = [0], m = 0, nums2 = [1], n = 1
        Output: [1]
        Explanation: The arrays we are merging are [] and [1].
        The result of the merge is [1].
        Note that because m = 0, there are no elements in nums1. The 0 is only there to ensure the merge result can fit in nums1.
     */
    public class MergeSortedArray
    {
        public IEnumerable<int> GetSortedArray(int[] array1, int[] array2)
        {
            if(array1 == null)
                throw new ArgumentNullException("array1 cant be null");

            if (array2 == null )
                throw new ArgumentNullException("array2 cant be null");

            if (array1.Length == 0) return array2;
            if (array2.Length == 0) return array1;

            var currentIndexArray1 = 0;
            var currentIndexArray2 = 0;
            var mergedList = new List<int>();
            while (currentIndexArray1 < array1.Length && currentIndexArray2 < array2.Length)
            {
                if(array1[currentIndexArray1] < array2[currentIndexArray2])
                {
                    mergedList.Add(array1[currentIndexArray1]);
                    currentIndexArray1++;
                }
                else
                {
                    mergedList.Add(array2[currentIndexArray2]);
                    currentIndexArray2++;
                }

            }
            if(currentIndexArray1 == array1.Length)
            {
                mergedList.AddRange(array2.Skip(currentIndexArray2).Take(array2.Length - currentIndexArray2));
            }
            else
            {
                mergedList.AddRange(array1.Skip(currentIndexArray1).Take(array1.Length - currentIndexArray1));
            }
            return mergedList;
        }
    }
}
