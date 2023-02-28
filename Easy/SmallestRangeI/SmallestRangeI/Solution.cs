namespace SmallestRangeI;

public class Solution
{
    public int SmallestRangeI(int[] nums, int k) 
    {
        if (nums.Length == 1)
        {
            return 0;
        }
        
        var min = nums.Min();
        var secondMin = nums.Max();

        if (Math.Abs(min - secondMin) <= k)
        {
            return 0;
        }
        else 
        {
            min += k;
            int l = 0;
            while (l < k)
            {
                if (min == secondMin)
                {
                    return 0;
                }
                secondMin -= 1;
                l++;
            }
            return secondMin - min;
        }
    }
}