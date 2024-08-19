using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HashMap
{
    public class HappyNumber
    {
        public bool IsHappy(int n)
        {
            HashSet<int> saw = new HashSet<int>();
            saw.Add(n);
            while (n != 1 && !saw.Contains(n))
            {
                saw.Add(n);
                n = sumOfSquares(n);
            }
            return n == 1;

        }
        private int sumOfSquares(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int digit = n % 10;
                sum += (int)Math.Pow(digit, 2);
                n /= 10;

            }
            return sum;
        }
    }
}
