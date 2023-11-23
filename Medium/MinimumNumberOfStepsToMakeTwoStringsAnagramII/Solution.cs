namespace MinimumNumberOfStepsToMakeTwoStringsAnagramII;

public class Solution 
{
    public int MinSteps(string s, string t) 
    {
        var sFreq = new Dictionary<char, int>();
        foreach (var c in s)
        {
            sFreq[c] = sFreq.GetValueOrDefault(c) + 1;
        }

        var tFreq = new Dictionary<char, int>();
        foreach (var c in t)
        {
            tFreq[c] = tFreq.GetValueOrDefault(c) + 1;
        }

        var steps = 0;
        foreach (var (c, count) in sFreq)
        {
            if (!tFreq.ContainsKey(c))
            {
                steps += count;
                tFreq[c] = count;
            }
            else
            {
                steps += Math.Abs(count - tFreq[c]);
            }
        }

        foreach (var (c, count) in tFreq)
        {
            if (!sFreq.ContainsKey(c))
            {
                steps += count;
            }
        }

        return steps;
    }
}