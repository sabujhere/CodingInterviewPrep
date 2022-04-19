using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscCodingProblems
{
    public class SquaresOfASortedArray
    {
        public int[] SortedSquares(int[] nums)
        {
            if (nums.Length <= 0) throw new ArgumentException();
            var sortedSquares = new int[nums.Length];// new List<int>(nums.Length);
            var posPointer = 0;
            
            while (nums[posPointer] < 0)
            {
                posPointer++;
            }
            var negativePointer = posPointer - 1;
            var count = 0;
            while (negativePointer >= 0 && posPointer < nums.Length)
            {
                if (nums[negativePointer] * nums[negativePointer] < nums[posPointer] * nums[posPointer])
                {
                    sortedSquares[count] = nums[negativePointer] * nums[negativePointer];
                    negativePointer --;
                }
                else
                {
                    sortedSquares[count] = nums[posPointer] * nums[posPointer];
                    posPointer++;
                }

                count++;
            }

            while (negativePointer > 0)
            {
                sortedSquares[count] = nums[negativePointer] * nums[negativePointer];
                negativePointer--;
                count++;
            }
            while (posPointer < nums.Length)
            {
                sortedSquares[count] = nums[posPointer] * nums[posPointer];
                posPointer++;
                count++;
            }

            return sortedSquares.ToArray();
        }
    }
}
