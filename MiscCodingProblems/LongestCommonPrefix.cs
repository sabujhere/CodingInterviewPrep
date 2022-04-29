using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscCodingProblems
{
    /// <summary>
    /// 14. Longest Common Prefix
    /// </summary>
    public class LongestCommonPrefix
    {
        public string GetLongestCommonPrefix(string[] strs)
        {
            var longestCommonPrefix = strs[0];
            for (var i = 1; i < strs.Length; i++)
            {
                while (!strs[i].StartsWith(longestCommonPrefix))
                {
                    longestCommonPrefix = longestCommonPrefix.Substring(0, longestCommonPrefix.Length - 1);
                }
            }

            return longestCommonPrefix;

        }
    }
}
