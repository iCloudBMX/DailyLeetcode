using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyLeetcode.Solutions.Arrays.Sliding_window
{
    public class FindAllAnagramsInString
    {
        public IList<int> FindAnagrams(string s, string p)
        {
            var result = new List<int>();

            if (s.Length < p.Length)
                return result;

            int[] sCount = new int[26];
            int[] pCount = new int[26];

            for (int i = 0; i < p.Length; i++)
            {
                pCount[p[i] - 'a']++;
                sCount[s[i] - 'a']++;
            }

            if (IsEqual(sCount, pCount))
                result.Add(0);

            for(int left = 0, right = p.Length; right < s.Length; right++)
            {
                sCount[s[right] - 'a']++;
                sCount[s[left++] - 'a']--;

                if (IsEqual(sCount, pCount))
                    result.Add(left);
            }

            return result;
        }

        public bool IsEqual(int[] sCount, int[] pCount)
        {
            for (int i = 0; i < 26; i++)
                if (sCount[i] != pCount[i])
                    return false;

            return true;
        }
    }
}
