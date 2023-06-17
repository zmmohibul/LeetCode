namespace MaximumProductSubarray;

public class Solution
{
    public int MaxProduct(int[] nums)
    {
        var max = int.MinValue;
        for (int i = 0; i < nums.Length; i++)
        {
            var prod = 1;
            for (int j = i; j < nums.Length; j++)
            {
                prod *= nums[j];
                max = Math.Max(prod, max);
            }
        }

        return max;
    }
}