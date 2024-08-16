using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.TwoPointer
{
    public class Subsequence
    {
        public bool IsSubsequence(string s, string t)
        {
            int sIndex = 0; int tIndex = 0;

            while (sIndex < s.Length && tIndex < t.Length)
            {
                if (s[sIndex] == t[tIndex])
                {
                    sIndex++;
                  
                }
                tIndex++;
            }
            return sIndex == s.Length;

        }

    }
}
