using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyLeetcode.Solutions.Arrays.Sort
{
    public static class SortColors
    {
        public static void SortColorsByAscending(int[] nums)
        {
            int[] colors = new int[3];

            for (int i = 0; i < nums.Length; i++)
                colors[nums[i]]++;

            int index = 0;

            while (colors[0]-- > 0)
                nums[index++] = 0;

            while (colors[1]-- > 0)
                nums[index++] = 1;

            while (colors[2]-- > 0)
                nums[index++] = 2;
        }
    }
}
