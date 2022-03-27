using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscCodingProblems
{
    public class ValidPalindrome
    {
        /// <summary>
        /// 125. Valid Palindrome
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool IsPalindrome(string s)
        {
            var fixedString = new StringBuilder();
            foreach (var c in s.ToCharArray())
            {
                if (char.IsLetterOrDigit(c))
                {
                    fixedString.Append(char.ToUpper(c));
                }
            }

            var startPointer = 0;
            var endPointer = fixedString.Length -1;
            while (startPointer < endPointer)
            {
                if (fixedString[startPointer] != fixedString[endPointer]) return false;

                startPointer++;
                endPointer--;
            }
            return true;
        }
    }
}
