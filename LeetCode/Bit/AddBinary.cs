using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Bit
{
    public class AddBinary1
    {
        public string AddBinary(string a, string b)
        {
            int maxLength = Math.Max(a.Length, b.Length);

            char[] result = new char[maxLength+1];
            int carry = 0;

            int i =a.Length-1;
            int j =b.Length-1;
            int k = maxLength;


            while (i>=0 || j>=0)
            {
                int sum = carry;
                if (i >= 0) sum += a[i--] - '0';
                if (j >= 0) sum += b[j--] - '0';
                result[k--] = (char)((sum % 2) + '0');
                carry = sum / 2;

            }
            if (carry != 0)
            {
                result[k] = (char)(carry + 0);

            }
            else
            {
                k++;
            }
            return new string(result, k, maxLength + 1 - k);


            //   for (int i = a.Length - 1; i >= 0; i--)
            //   {
            //
            //       if (a == 0 & b == 0)
            //       {
            //
            //       }
            //
            //
            //
            //   }
            //
            //
            //   StringBuilder result = new StringBuilder();
            //   result.Inset(0, b)
        }
    }
}

