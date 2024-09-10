using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.WorkingArry
{
    public class H_Index
    {
        public int HIndex(int[] citations)
        {
            var sortedCitations = citations.OrderByDescending(x => x).ToArray();
            int hIndex = 0;

            for (int i = 0; i < sortedCitations.Length; i++)
            {
                if (i + 1 <= sortedCitations[i])
                {
                    hIndex = i + 1;
                }
               
            }

            return hIndex;
        }
    }
}