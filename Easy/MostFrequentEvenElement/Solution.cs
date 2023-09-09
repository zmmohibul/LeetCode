namespace MostFrequentEvenElement;

public class Solution
{
    public int MostFrequentEven(int[] nums)
    {
        var evenFreq = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            if (num % 2 == 0)
            {
                evenFreq[num] = evenFreq.GetValueOrDefault(num, 0) + 1;
            }
        }

        if (evenFreq.Count == 0)
        {
            return -1;
        }

        var maxFreq = 0;
        foreach (var (n, count) in evenFreq)
        {
            maxFreq = Math.Max(maxFreq, count);
        }

        var min = int.MaxValue;
        foreach (var (n, count) in evenFreq)
        {
            if (count == maxFreq)
            {
                min = Math.Min(min, n);
            }
        }

        return min;
    }
}