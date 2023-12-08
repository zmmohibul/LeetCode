namespace CountCompleteSubarraysinArray;

public class Solution {
    public int CountCompleteSubarrays(int[] nums) {
        var uniques = new HashSet<int>(nums);
        var freq = new Dictionary<int, int>();
        
        int left = 0, right = 0, count = 0;
        while (right < nums.Length)
        {
            while (right < nums.Length && freq.Count != uniques.Count)
            {
                freq[nums[right]] = freq.GetValueOrDefault(nums[right]) + 1;
                right++;
            }
            
            if (freq.Count == uniques.Count)
            {
                count += (nums.Length - right + 1);
            }

            freq[nums[left]] -= 1;
            if (freq[nums[left]] == 0)
            {
                freq.Remove(nums[left]);
            }

            left++;
        }

        while (left < nums.Length && freq.Count == uniques.Count)
        {
            count++;
            
            freq[nums[left]] -= 1;
            if (freq[nums[left]] == 0)
            {
                freq.Remove(nums[left]);
            }

            left++;
        }

        return count;
    }
}