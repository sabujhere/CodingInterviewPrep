using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscCodingProblems
{
    public class FibonacciNumber
    {
        public int GetUsingRecursion(int position)
        {
            if(position <=1) return position;
            return GetUsingRecursion(position-1) + GetUsingRecursion(position -2);
        }
        public int GetUsingIteration(int position)
        {
            if (position <= 1) return position;
            var result = new int[2] {0,1};
            for (int i = 2; i <= position; i++)
            {
                var posIndex1 = result[1];
                result[1] = result[0] + result[1];
                result[0] = posIndex1;
            }
            return result[1];
        }
    }
}
