using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyLeetcode.Solutions.Arrays.Sliding_window
{
    public static class MinimumSizeSubarraySum
    {
        public static int MinSubArrayLen(int target, int[] nums)
        {
            int minLength = int.MaxValue;
            int sum = 0, left = 0;

            for(int right = 0; right < nums.Length; right++)
            {
                sum += nums[right];

                while(sum >= target)
                {
                    minLength = Math.Max(minLength, right - left + 1);
                    sum -= nums[left++];
                }
            }

            return minLength == int.MaxValue ? 0 : minLength;
        }
    }
}
