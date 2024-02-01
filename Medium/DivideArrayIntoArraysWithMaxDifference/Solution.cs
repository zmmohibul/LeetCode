namespace DivideArrayIntoArraysWithMaxDifference;

public class Solution {
    public int[][] DivideArray(int[] nums, int k) {
        Array.Sort(nums);
        var n = nums.Length / 3;
        var result = new int[n][];
        var mainIndex = 0;
        for (int i = 0; i < n; i++)
        {
            var subResult = new int[3];
            for (int j = 0; j < 3; j++)
            {
                subResult[j] = nums[mainIndex];
                mainIndex++;
            }

            var diff1 = subResult[1] - subResult[0];
            var diff2 = subResult[2] - subResult[1];
            var diff3 = subResult[2] - subResult[0];

            if (diff1 > k || diff2 > k || diff3 > k)
            {
                return new int[0][];
            }

            result[i] = subResult;
        }

        return result;
    }
}