namespace ArmstrongNumber;

public class Solution
{
    public bool IsArmstrong(int n)
    {
        var nums = new List<int>();
        var orgN = n;
        while (n > 0)
        {
            nums.Add(n % 10);
            n /= 10;
        }

        long sum = 0;
        for (int i = 0; i < nums.Count; i++)
        {
            sum += (long) Math.Pow(nums[i], nums.Count);
            if (sum > orgN)
            {
                return false;
            }
        }

        if (sum == orgN)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}