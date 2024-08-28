﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Arrays
{
    public class JUMPII
    {
        public int Jump(int[] nums)
        {
            int jumps = 0, currentEnd = 0, farthest = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                farthest = Math.Max(farthest, i + nums[i]);
                if (i == currentEnd)
                {
                    jumps ++;
                    currentEnd = farthest;
                }
                
            }
            return jumps;
        }
    }
}
