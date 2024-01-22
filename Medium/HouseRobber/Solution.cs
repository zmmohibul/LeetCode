namespace HouseRobber;

public class Solution {
    Dictionary<string, int> cache = new();
    public int Rob(int[] nums) {
        return Math.Max(
            KnapSack(nums, nums.Length - 1, true),
            KnapSack(nums, nums.Length - 1, false)
        );
    }

    public int KnapSack(int[] nums, int i, bool canRob)
    {
        var key = $"{i}-{canRob}";
        if (cache.ContainsKey(key))
        {
            return cache[key];
        }

        if (i == -1)
        {
            return 0;
        }

        int result = 0;
        if (!canRob)
        {
            result = KnapSack(nums, i - 1, true);
        }
        else
        {
            int canRobAmount = nums[i] + KnapSack(nums, i - 1, false);
            int notCanRobAmount = KnapSack(nums, i - 1, true);
            result = Math.Max(canRobAmount, notCanRobAmount);
        }

        
        cache[$"{i}-{canRob}"] = result;
        return result;
    }
}