namespace KDiffPairsInAnArray;

public class Solution {
    public int FindPairs(int[] nums, int k) {
        
        var freq = new Dictionary<int, int>();
        foreach (var n in nums)
        {
            freq[n] = freq.GetValueOrDefault(n) + 1;
        }

        var count = 0;
        var seenPairs = new HashSet<Tuple<int, int>>();
        foreach (var (n, c) in freq)
        {
            if (k == 0)
            {
                if (c > 1) count++;
                continue;
            }

            var smallDiff = n - k;
            if (DictContainsUniquePair(freq, seenPairs, n, smallDiff)) count++;
            
            var largeDiff = n + k;
            if (DictContainsUniquePair(freq, seenPairs, n, smallDiff)) count++;
        }

        return count;
    }

    private bool DictContainsUniquePair(Dictionary<int, int> d, HashSet<Tuple<int, int>> sp, int n1, int n2)
    {
        if (d.ContainsKey(n2))
        {
            var pair = new Tuple<int, int>(
                Math.Min(n1, n2),
                Math.Max(n1, n2)
            );
                
            if(!sp.Contains(pair))
            {
                sp.Add(pair);
                return true;
            }
        }

        return false;
    }
}