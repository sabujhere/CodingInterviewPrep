namespace SlidingWindowsForStrings
{
/* 76. Minimum Window Substring

   Given two strings s and t of lengths m and n respectively, return the minimum window substring of s such that every character in t (including duplicates) is included in the window. If there is no such substring, return the empty string "".
   
   The testcases will be generated such that the answer is unique.
   
   A substring is a contiguous sequence of characters within the string.
   
   
   
   Example 1:
   
   Input: s = "ADOBECODEBANC", t = "ABC"
   Output: "BANC"
   Explanation: The minimum window substring "BANC" includes 'A', 'B', and 'C' from string t.
   Example 2:
   
   Input: s = "a", t = "a"
   Output: "a"
   Explanation: The entire string s is the minimum window.
   Example 3:
   
   Input: s = "a", t = "aa"
   Output: ""
   Explanation: Both 'a's from t must be included in the window.
   Since the largest window of s only has one 'a', return empty string.
   
   
   Constraints:
   
   m == s.length
   n == t.length
   1 <= m, n <= 105
   s and t consist of uppercase and lowercase English letters.
   
   
   Follow up: Could you find an algorithm that runs in O(m + n) time?
*/

    public class MinimumWindowSubstring
    {
        public string GetSubString(string str, string pattern)
        {
            var frequencyTable = new Dictionary<char, int>();
            foreach (var c in pattern)
            {
                if (frequencyTable.ContainsKey(c))
                {
                    frequencyTable[c]++;
                }
                else
                {
                    frequencyTable.Add(c, 1);
                }
            }

            int start = 0, end = 0;
            int counter = frequencyTable.Keys.Count;
            string res = string.Empty;
            while (end < str.Length)
            {
                char endChar = str[end];
                if (frequencyTable.ContainsKey(endChar))
                {
                    frequencyTable[endChar]--;
                    if (frequencyTable[endChar] == 0)
                    {
                        counter--;
                    }
                }
                end++;

                while (counter == 0)
                {
                    var currentWindow = str.Substring(start, end - start);
                    if (res == string.Empty || currentWindow.Length < res.Length)
                    {
                        res = currentWindow;
                    }

                    var startChar = str[start];
                    if (frequencyTable.ContainsKey(startChar))
                    {
                        frequencyTable[startChar]++;
                        if (frequencyTable[startChar] > 0)
                        {
                            counter++;
                        }
                    }
                    start++;

                }

            }
            return res;
        }

    }
}