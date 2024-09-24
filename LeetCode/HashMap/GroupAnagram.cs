using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HashMap
{
    public class GroupAnagram
    {

        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var anagrams = new Dictionary<string, List<string>>();

            foreach (var s in strs)
            {
                // Sort the string and use it as a key
                var key = new string(s.OrderBy(c => c).ToArray());
                if (!anagrams.ContainsKey(key))
                {
                    anagrams[key] = new List<string>();
                }
                anagrams[key].Add(s);
            }

            return anagrams.Values.ToList<IList<string>>();
        }
    }
}

