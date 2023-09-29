namespace MonotonicArray;

public class Solution 
{
    public bool IsMonotonic(int[] nums) 
    {
        var isMonotoneDecreasing = true;
        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i + 1] > nums[i])
            {
                isMonotoneDecreasing = false;
                break;
            }
        }

        if (isMonotoneDecreasing)
        {
            return true;
        }

        var isMonotoneIncreasing = true;
        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i + 1] < nums[i])
            {
                isMonotoneIncreasing = false;
                break;
            }
        }

        return isMonotoneIncreasing;
    }
}