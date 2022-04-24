using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscCodingProblems
{
    /// <summary>
    /// 20. Valid Parentheses
    /// </summary>
    public class ValidParentheses
    {
        public bool IsValid(string s)
        {
            if (s.Length % 2 != 0) return false;
            var startBrakets = new List<char>() {'(', '{', '['}.ToHashSet();
            var endBrakets = new List<char>() {')', '}', ']'}.ToHashSet();

            var braketStack = new Stack<char>();
            foreach (var charItem in s)
            {
                if (startBrakets.Contains(charItem))
                {
                    braketStack.Push(charItem);
                }
                else if (endBrakets.Contains(charItem))
                {
                    var expectedBraket = GetStartBraket(charItem);
                    var popResult = braketStack.TryPop(out var actualBraket);
                   
                    if (!popResult || actualBraket != expectedBraket) return false;
                }
            }
            if(braketStack.Any()) return false;
            return true;

        }

        public char GetStartBraket(char endBraket)
        {
            switch (endBraket)
            {
                case ')':
                    return '(';
                case '}':
                    return '{';
                case ']':
                    return '[';
                default:
                    throw new ArgumentException();
            }
        }
    }
}
