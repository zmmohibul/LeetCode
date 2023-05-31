namespace ThreeSumClosest;

public class Solution
{
    public int ThreeSumClosest(int[] nums, int target)
    {
        var diff = int.MaxValue;
        var result = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                for (int k = j + 1; k < nums.Length; k++)
                {
                    var sum = nums[i] + nums[j] + nums[k];
                    var cdiff = Math.Abs(sum - target);
                    if (cdiff < diff)
                    {
                        diff = cdiff;
                        result = sum;
                    }
                }
            }
        }

        return result;
    }
}