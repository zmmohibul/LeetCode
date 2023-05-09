namespace FindTheDistinctDifferenceArray;

public class Solution
{
    public int[] DistinctDifferenceArray(int[] nums)
    {
        var freq = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            var n = nums[i];
            freq[n] = freq.GetValueOrDefault(n, 0) + 1;
        }

        var prefix = new HashSet<int>();
        var result = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            prefix.Add(nums[i]);
            freq[nums[i]] -= 1;
            if (freq[nums[i]] == 0)
            {
                freq.Remove(nums[i]);
            }

            result[i] = prefix.Count - freq.Count;
        }

        return result;
    }
}