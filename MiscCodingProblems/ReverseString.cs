using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscCodingProblems
{
    /// <summary>
    /// 141. Linked List Cycle
    /// </summary>
    public class ReverseString
    {
        public void Reverse(char[] s)
        {
            var start = 0;
            var end = s.Length - 1;
            while (start < end)
            {
                (s[start], s[end]) = (s[end], s[start]);
                start++;
                end--;
            }
        }
    }
}
