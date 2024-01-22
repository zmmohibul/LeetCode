namespace HouseRobberII;

public class Solution {
    Dictionary<string, int> cache = new();
    public int Rob(int[] nums) {
        if (nums.Length == 1)
        {
            return nums[0];
        }
        
        return Math.Max(
            KnapSack(nums, nums.Length - 1, true, true),
            KnapSack(nums, nums.Length - 1, false, false)
        );
    }

    public int KnapSack(int[] nums, int i, bool canRob, bool lastHouseRobbed)
    {
        var key = $"{i}-{canRob}-{lastHouseRobbed}";
        if (cache.ContainsKey(key))
        {
            return cache[key];
        }

        if (i == -1)
        {
            return 0;
        }

        int result = 0;
        if (i == 0 && lastHouseRobbed)
        {
            canRob = false;
        }

        if (!canRob)
        {
            result = KnapSack(nums, i - 1, true, lastHouseRobbed);
        }
        else
        {
            int canRobAmount = nums[i] + KnapSack(nums, i - 1, false, lastHouseRobbed);            
            int notCanRobAmount = KnapSack(nums, i - 1, true, lastHouseRobbed);
            result = Math.Max(canRobAmount, notCanRobAmount);
        }

        
        cache[$"{i}-{canRob}-{lastHouseRobbed}"] = result;
        return result;
    }
}