namespace NumberOfPairsOfStringsWithConcatenationEqualToTarget;

public class Solution {
    public int NumOfPairs(string[] nums, string target) {
        var indexMap = new Dictionary<string, HashSet<int>>();
        for (var i = 0; i < nums.Length; i++)
        {
            if (!indexMap.ContainsKey(nums[i]))
            {
                indexMap[nums[i]] = new();
            }

            indexMap[nums[i]].Add(i);
        }

        var count = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            var str = nums[i];
            if (str.Length < target.Length)
            {
                var other = target.Substring(str.Length);
                var concat = str + other;
                if (concat == target && indexMap.ContainsKey(other))
                {
                    var otherIndices = indexMap[other];
                    count += otherIndices.Count;

                    if (otherIndices.Contains(i))
                    {
                        count -= 1;
                    }
                }
            }
        }

        return count;
        
    }
}