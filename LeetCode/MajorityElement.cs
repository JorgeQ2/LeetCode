using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MajorityElements
    {
        public int MajorityElement(int[] nums)
        {
            int count = 0;
            int stored = 0;

            //iterate to array elements
            foreach (int num in nums)
            {
                //if count 0 update stored
                if (count == 0)
                {
                    stored = num;
                }
                //updating count basically if else
                count += (num == stored) ? 1 : -1;
            }
            //returns majority
            return stored;

            //545


        }
    }
}
