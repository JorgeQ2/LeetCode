﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class RemoveDups
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0; 

            int k = 1; 
            for (int i = 1; i < nums.Length; i++)
            { 
                if (nums[i] != nums[k - 1])
                {
                    nums[k] = nums[i]; 
                    k++; 
                }
            }
            return k;

        }
    }


  
            
}
