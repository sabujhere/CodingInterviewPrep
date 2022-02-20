using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscCodingProblems
{
    /*
     * 1903. Largest Odd Number in String
     * You are given a string num, representing a large integer. Return the largest-valued odd integer (as a string) that is a non-empty substring of num, or an empty string "" if no odd integer exists.

        A substring is a contiguous sequence of characters within a string.

 

        Example 1:

        Input: num = "52"
        Output: "5"
        Explanation: The only non-empty substrings are "5", "2", and "52". "5" is the only odd number.
        Example 2:

        Input: num = "4206"
        Output: ""
        Explanation: There are no odd numbers in "4206".
        Example 3:

        Input: num = "35427"
        Output: "35427"
        Explanation: "35427" is already an odd number.
     * */
    public class LargestOddNumberInString
    {
        public string Get(string num)
        {
            for(int i = num.Length; i > 0 ; i--)
            {
                var currentNum = int.Parse( num.ElementAt(i-1).ToString());
                var isOdd = currentNum % 2 == 1;

                if (isOdd)
                {
                    return num.Substring(0,i);
                }
                
            }
            return "";
        }
    }
}
