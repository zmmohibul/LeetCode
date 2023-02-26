namespace PermutationsII;

public class Solution
{
    public IList<IList<int>> PermuteUnique(int[] nums)
    {
        return PermuteUnique(nums.ToList());
    }

    public IList<IList<int>> PermuteUnique(List<int> nums)
    {
        if (nums.Count == 0)
        {
            return new List<IList<int>>() { new List<int>() };
        }
        else
        {
            var result = new List<IList<int>>();
            var seenValues = new HashSet<int>();
            for (int i = 0; i < nums.Count; i++)
            {
                if (seenValues.Contains(nums[i]))
                {
                    continue;
                }

                seenValues.Add(nums[i]);
                
                var remaining = new List<int>();
                for (int j = 0; j < nums.Count; j++)
                {
                    if (j != i)
                    {
                        remaining.Add(nums[j]);
                    }
                }
                
                var remainingPermutation = PermuteUnique(remaining);
                foreach (var item in remainingPermutation)
                {
                    item.Add(nums[i]);
                    result.Add(item);
                }
            }

            return result;
        }
    }
}