using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyLeetcode.Solutions.Arrays.Sliding_window
{
    public static class FindTheKBeautyOfNumber
    {
        public static int DivisorSubstrings(int num, int k)
        {
            string str = num.ToString();
            int sum = 0, count = 0;

            for (int i = 0; i < k; i++)
                sum = sum * 10 + (str[i] - '0');

            if (isBeauty(num, sum))
                count++;

            for (int right = k, left = 0; right < str.Length; right++)
            {
                sum -= (str[left++] - '0') * (int)Math.Pow(10, k - 1);
                sum = sum * 10 + (str[right] - '0');

                if (isBeauty(num, sum))
                    count++;
            }

            return count;
        }

        public static bool isBeauty(int num, int sum)
        {
            if (sum == 0)
                return false;

            return num % sum == 0;
        }
    }
}
