namespace CountNicePairsInArray;

public class Solution {
    public int CountNicePairs(int[] nums) {
        for (int i = 0; i < nums.Length; i++)
        {
            var rev = 0;
            var n = nums[i];
            while (n > 0)
            {
                rev *= 10;
                rev += (n % 10);
                n /= 10;
            }

            nums[i] = nums[i] - rev;
        }

        var count = 0;
        var map = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            if (map.ContainsKey(num))
            {
                count = (count + map[num]) % 1000000007;
            }

            map[num] = map.GetValueOrDefault(num) + 1;
        }

        return count;
    }
}