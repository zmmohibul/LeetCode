namespace CountNumberOfDistinctIntegersAfterReverseOperations;

public class Solution 
{
    public int CountDistinctIntegers(int[] nums) {
        var distinct = new HashSet<int>();
        var reverseNumberMap = new Dictionary<int, int>();
        
        for (int i = 0; i < nums.Length; i++)
        {
            var num = nums[i];
            distinct.Add(num);

            if (!reverseNumberMap.ContainsKey(num))
            {
                var numReversed = 0;
                while (num > 0) 
                {
                    numReversed *= 10;
                    numReversed += num % 10;
                    num /= 10;
                }
                distinct.Add(numReversed);

                if (nums[i] % 10 != 0)
                {
                    reverseNumberMap[nums[i]] = numReversed;
                }
            }

            
        }
        return distinct.Count;
    }
}