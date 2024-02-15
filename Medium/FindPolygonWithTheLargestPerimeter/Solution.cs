namespace FindPolygonWithTheLargestPerimeter;

public class Solution {
    public long LargestPerimeter(int[] nums) {
        Array.Sort(nums);
        
        var prefixSums = new long[nums.Length];
        long sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            prefixSums[i] = sum;
        }

        for (int i = nums.Length - 1; i > 1; i--)
        {
            if (nums[i] < prefixSums[i - 1])
            {
                return prefixSums[i];
            }
        }

        return -1;
    }
}