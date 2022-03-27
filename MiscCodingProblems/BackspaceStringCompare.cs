using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscCodingProblems
{
    public class BackspaceStringCompare
    {
        /// <summary>
        /// 844. Backspace String Compare
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public bool GetResult(string s, string t)
        {
            var sPointer = s.Length - 1;
            var tPointer = t.Length - 1;
            var sSkips = 0;
            var tSkips = 0;
            while (sPointer >= 0 || tPointer >= 0)
            {
                while (sPointer >= 0)
                {
                    var currentChar = s[sPointer];
                    if (currentChar == '#')
                    {
                        sSkips++;
                        sPointer--;
                    }
                    else if (sSkips > 0)
                    {
                        sPointer--;
                        sSkips--;
                    }
                    else
                    {
                        break;
                    }
                }
                while (tPointer >= 0)
                {
                    var currentChar = t[tPointer];
                    if (currentChar == '#')
                    {
                        tSkips++;
                        tPointer--;
                    }
                    else if (tSkips > 0)
                    {
                        tPointer--;
                        tSkips--;
                    }
                    else
                    {
                        break;
                    }
                }

                if (sPointer >= 0 && tPointer >= 0 && s[sPointer] != t[tPointer] )
                {
                    return false;
                }

                if ((sPointer >= 0) != (tPointer>=0))
                {
                    return false;
                }

                sPointer--;
                tPointer--;
            }
            
            return true;
        }
    }
}
