using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyLeetcode.Solutions.Arrays.Two_pointers
{
    public static class MergeTwoSortedArray
    {
        public static void Merge(int[] nums1, int n, int[] nums2, int m)
        {
            int lastIndex = n + m - 1;
            n--;
            m--;

            while(n >= 0)
            {
                if (m >= 0 && nums1[m] > nums2[n])
                    nums1[lastIndex--] = nums1[m--];
                else
                    nums1[lastIndex--] = nums2[n--];
            }
        }
    }
}
