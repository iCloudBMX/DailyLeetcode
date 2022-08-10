using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyLeetcode.Solutions.Arrays.Sliding_window
{
    public static class LongestSubstringWithoutRepeatingCharacters
    {
        public static int LengthOfLongestSubstring(string s)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();

            int left = 0, right = 0;
            int maxLength = 0;

            while (right < s.Length && left < s.Length)
            {
                if (dict.ContainsKey(s[right]))
                    dict.Remove(s[left++]);
                else
                {
                    maxLength = Math.Max(maxLength, right - left + 1);
                    dict.Add(s[right++], 0);
                }
            }

            return maxLength;
        }
    }
}
