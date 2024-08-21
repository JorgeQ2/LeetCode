using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Day1
{
    public class LengthOfLastWords
    {
        public int LengthOfLastWord(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;

            int length = 0;
            bool isWord = false;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] != ' ')
                {
                    isWord = true;
                    length++;
                }
                else if (isWord)
                {

                    break;
                }
            }

            return length;

        }
    }
}
