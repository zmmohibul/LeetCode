namespace Maximum_Ascending_Subarray_Sum;

public class Solution {
    public int MaxAscendingSum(int[] nums) {
        int sum = nums[0];
        int max = sum;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i - 1] >= nums[i])
            {
                max = Math.Max(sum, max);
                sum = 0;
            }
            sum += nums[i];
        }
        
        max = Math.Max(sum, max);
        return max;
    }
}