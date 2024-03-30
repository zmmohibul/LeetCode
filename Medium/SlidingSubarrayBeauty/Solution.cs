namespace SlidingSubarrayBeauty;

public class Solution {
    public int[] GetSubarrayBeauty(int[] nums, int k, int x) {
        var result = new List<int>();
        var freq = new SortedDictionary<int, int>();

        var right = 0;
        for (; right < k; right++)
        {
            freq[nums[right]] = freq.GetValueOrDefault(nums[right]) + 1;
        }

        AddValueToResult(result, freq, x);

        var left = 0;
        for (; right < nums.Length; right++)
        {
            freq[nums[left]]--;
            if (freq[nums[left]] == 0)
            {
                freq.Remove(nums[left]);
            }
            left++;
            
            freq[nums[right]] = freq.GetValueOrDefault(nums[right]) + 1;

            AddValueToResult(result, freq, x);
        }

        return result.ToArray();
    }

    public void AddValueToResult(List<int> result, SortedDictionary<int, int> freq, int x)
    {
        var valueToAdd = 0;
        var ix = 0;
        foreach (var (n, count) in freq)
        {
            ix += count;

            if (ix >= x)
            {
                valueToAdd = n;
                break;
            }
            else
            {
                valueToAdd = n;
            }
        }
        result.Add(valueToAdd > -1 ? 0 : valueToAdd);
    }
}