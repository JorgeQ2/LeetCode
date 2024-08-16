using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HashMap
{
    internal class Isomorphic
    {
        public bool IsIsomorphic(string s, string t)
        {
            if (s.Length != t.Length) return false;

            Dictionary<char, char> mapST = new Dictionary<char, char>();
            Dictionary<char, char> mapTS = new Dictionary<char, char>();

            for (int i = 0; i < s.Length; i++)
            {
                char charS = s[i];
                char charT = t[i];

                if (mapST.ContainsKey(charS))
                {
                    if (mapST[charS] != charT) return false;
                }
                else
                {
                    mapST[charS] = charT;
                }

                if (mapTS.ContainsKey(charT))
                {
                    if (mapTS[charT] != charS) return false;
                }
                else
                {
                    mapTS[charT] = charS;
                }
            }

            return true;
        }
    }

}
