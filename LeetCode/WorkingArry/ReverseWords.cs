using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.WorkingArry
{
    public class ReverseWords1
    {
        public string ReverseWords(string s)
        {
            string[] words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            // Reverse the array of words
            Array.Reverse(words);

            // Join the words with a single space
            return string.Join(' ', words);
        }
    }
}
