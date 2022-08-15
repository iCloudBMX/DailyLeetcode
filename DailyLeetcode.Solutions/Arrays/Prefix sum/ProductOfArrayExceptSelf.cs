using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyLeetcode.Solutions.Arrays.Prefix_sum
{
    public static class ProductOfArrayExceptSelf
    {
        public static int[] ProductExceptSelf(int[] nums)
        {
            int[] answer = new int[nums.Length];
            
            answer[0] = 1;

            for (int i = 1; i < answer.Length; i++)
                answer[i] = answer[i - 1] * nums[i - 1];

            int right = 1;

            for(int i = nums.Length - 1; i >= 0; i--)
            {
                answer[i] *= right;
                right *= nums[i];
            }

            return answer;
        }
    }
}
