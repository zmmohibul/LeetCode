namespace LongestHarmoniousSubsequence;

public class Solution {
    public int FindLHS(int[] nums) {
        var numCount = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            numCount[num] = numCount.GetValueOrDefault(num, 0) + 1;
        }

        var maxCount = 0;
        foreach (var (num, count) in numCount)
        {
            var currCount = 0;
            if (numCount.ContainsKey(num + 1))
            {
                currCount = count + numCount[num + 1];
            }

            maxCount = Math.Max(currCount, maxCount);
        }

        return maxCount;
    }
}