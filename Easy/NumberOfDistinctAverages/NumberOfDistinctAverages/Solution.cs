namespace NumberOfDistinctAverages;

public class Solution
{
    public int DistinctAverages(int[] nums)
    {
        Array.Sort(nums);
        var i = 0;
        var j = nums.Length - 1;
        var hs = new HashSet<double>();
        while (i < j)
        {
            double average = (nums[i] + nums[j]) / 2.0;
            hs.Add(average);
            
            i++;
            j--;
        }

        return hs.Count;
    }
}