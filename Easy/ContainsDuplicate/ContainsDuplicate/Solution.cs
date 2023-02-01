namespace ContainsDuplicate;

public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        var seenValues = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (seenValues.Contains(nums[i]))
            {
                return true;
            }

            seenValues.Add(nums[i]);
        }

        return false;
    }
}