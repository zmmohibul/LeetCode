namespace CountLargestGroup;

public class Solution
{
    public int CountLargestGroup(int n)
    {
        var groups = new Dictionary<int, List<int>>();
        var largestGroupSize = 0;
        for (int i = 1; i <= n; i++)
        {
            var num = i;
            var numSum = 0;
            while (num > 0)
            {
                numSum += num % 10;
                num /= 10;
            }

            if (!groups.ContainsKey(numSum))
            {
                groups[numSum] = new List<int>();
            }
            
            groups[numSum].Add(i);
            if (groups[numSum].Count > largestGroupSize)
            {
                largestGroupSize = groups[numSum].Count;
            }
        }

        var ans = 0;
        foreach (var (key, value) in groups)
        {
            if (value.Count == largestGroupSize)
            {
                ans++;
            }
        }

        return ans;
    }
}