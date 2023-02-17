namespace FindSubarraysWithEqualSum;

public class Solution
{
    public bool FindSubarrays(int[] nums)
    {
        var sum = nums[0] + nums[1];
        
        var seenSums = new HashSet<int>();
        seenSums.Add(sum);
        
        var j = 0;
        for (int i = 2; i < nums.Length; i++)
        {
            sum -= nums[j];
            j++;
            
            sum += nums[i];
            if (seenSums.Contains(sum))
            {
                return true;
            }

            seenSums.Add(sum);
        }

        return false;
    }
}