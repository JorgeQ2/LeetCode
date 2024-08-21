using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Day1
{
    public class TwoSums
    {
        public int[] TwoSum(int[] nums, int target)
        {
            HashSet<int> set = new HashSet<int>();
            //used for loop
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                //check for compliment
                if (set.Contains(complement))
                {
                    //if exist we return 
                    return new int[] { Array.IndexOf(nums, complement), i };
                }
                //add to hash  if not there
                set.Add(nums[i]);
            }
            throw new ArgumentException("No two sum solution");
        }

    }
}