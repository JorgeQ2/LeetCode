using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.WorkingArry
{
    public class ProductOfArray
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            int n = nums.Length;
            int[] answer = new int[n];

            // Initialize the answer array with 1s
            for (int i = 0; i < n; i++)
            {
                answer[i] = 1;
            }

            // Calculate prefix products
            int prefix = 1;
            for (int i = 0; i < n; i++)
            {
                answer[i] = prefix;
                prefix *= nums[i];
            }

            // Calculate suffix products and multiply with prefix products
            int suffix = 1;
            for (int i = n - 1; i >= 0; i--)
            {
                answer[i] *= suffix;
                suffix *= nums[i];
            }

            return answer;
        }
    }
}

