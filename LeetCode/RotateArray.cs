using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class RotateArray
    {
        public void Rotate(int[] nums, int k)
        {
            int n = nums.Length;
            
            k = k % n;
            int mid = n - k;

            int[] rotated = nums[mid..].Concat(nums[0..mid]).ToArray();

            for (int i = 0; i < n; i++)
            {
                nums[i] = rotated[i];
            }

        }
    }



    //for (int i = 0; i < k; i++)
    //{
    //    int temp = nums[^1];
    //
    //    Array.Copy(nums[0..^1], 0, nums, 1, nums.Length - 1);
    //    nums[0] = temp;
    //
    //    
    //}
}

