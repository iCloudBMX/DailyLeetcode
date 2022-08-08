using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyLeetcode.Solutions.Arrays.Sliding_window
{
    public static class ContainsDuplicateIII
    {
        public static bool ContainsNearbyAlmostDuplicate(int[] nums, int k, int t)
        {
            if (nums.Length <= 1 || k <= 0)
                return false;

            Dictionary<long, long> buckets = new Dictionary<long, long>();
            long bucketSize = (long)t + 1;

            for(int i = 0; i < nums.Length; i++)
            {
                long remappedNum = (long)nums[i] - int.MinValue;
                long bucket = remappedNum / bucketSize;

                if (buckets.ContainsKey(bucket))
                    return true;

                if (buckets.ContainsKey(bucket - 1) &&
                    remappedNum - buckets[bucket - 1] <= t)
                        return true;

                if (buckets.ContainsKey(bucket + 1) &&
                    buckets[bucket + 1] - remappedNum <= t)
                    return true;

                buckets.Add(bucket, remappedNum);

                if(i > k)
                {
                    long lastmappedNum = (long)nums[i - k - 1] - int.MinValue;
                    buckets.Remove(lastmappedNum / bucketSize);
                }
            }

            return false;
        }
    }
}
