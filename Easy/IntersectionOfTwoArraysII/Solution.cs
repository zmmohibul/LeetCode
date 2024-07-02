namespace IntersectionOfTwoArraysII;

public class Solution 
{
    public int[] Intersect(int[] nums1, int[] nums2) 
    {
        var freqNums1 = GetFrequencyMapOfArrayElements(nums1);
        var freqNums2 = GetFrequencyMapOfArrayElements(nums2);
        var result = new List<int>();
        foreach (var (n, count) in freqNums1)
        {
            var leastCount = Math.Min(count, freqNums2.GetValueOrDefault(n));
            for (var i = 0; i < leastCount; i++)
            {
                result.Add(n);
            }
        }

        return result.ToArray();
    }

    private Dictionary<int, int> GetFrequencyMapOfArrayElements(int[] nums)
    {
        var freq = new Dictionary<int, int>();
        foreach (var n in nums)
        {
            freq[n] = freq.GetValueOrDefault(n) + 1;
        }

        return freq;
    }
}