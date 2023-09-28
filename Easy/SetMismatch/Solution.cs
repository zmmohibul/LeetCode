namespace SetMismatch;

public class Solution {
    public int[] FindErrorNums(int[] nums) {
        var result = new int[2];

        var seen = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (seen.Contains(nums[i]))
            {
                result[0] = nums[i];
                break;
            }

            seen.Add(nums[i]);
        }
        seen = null;

        var numsSet = new HashSet<int>(nums);
        for (int i = 1; i <= nums.Length; i++)
        {
            if (!numsSet.Contains(i))
            {
                result[1] = i;
                return result;
            }
        }

        return result;
    }
}