using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscCodingProblems
{
    /// <summary>
    /// 709. To Lower Case
    /// </summary>
    public class ToLowerCase
    {
        public string ToLower(string s)
        {
            var returnResult = new StringBuilder();
            foreach (var currentChar in s.ToCharArray())
            {
                if (char.IsUpper(currentChar))
                {
                    returnResult.Append((char)(currentChar + 32));
                    continue;
                }

                returnResult.Append(currentChar);
            }

            return returnResult.ToString();
        }
    }
}
