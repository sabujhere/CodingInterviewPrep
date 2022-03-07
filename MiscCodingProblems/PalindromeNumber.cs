using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscCodingProblems
{
    /// <summary>
    /// 9. Palindrome Number
    /// </summary>
    public class PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            if (x == 0) return true;
            if (x < 0  || x % 10 == 0) return false;

            var reverseNumber = 0;
            while (x > reverseNumber)
            {
                var pop = x % 10;
                x = x / 10;
                reverseNumber = reverseNumber * 10 + pop;
            }

            return x == reverseNumber || x == reverseNumber / 10;
        }
    }
}
