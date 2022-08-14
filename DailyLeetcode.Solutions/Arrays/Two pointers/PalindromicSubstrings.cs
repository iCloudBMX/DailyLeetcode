using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyLeetcode.Solutions.Arrays.Two_pointers
{
    public static class PalindromicSubstrings
    {
        public static int CountSubstrings(string s)
        {
            int count = 0;

            for (int i = 0; i < s.Length; i++)
            {
                count += FindPalindromeCount(s, i, i); // odd length palindromic sub-string
                count += FindPalindromeCount(s, i, i + 1); // even length palindromic sub-string
            }

            return count;
        }

        public static int FindPalindromeCount(string s, int left, int right)
        {
            int count = 0;

            while (left >= 0 && right < s.Length&& s[left--] == s[right++])
                count++;

            return count;
        }
    }
}
