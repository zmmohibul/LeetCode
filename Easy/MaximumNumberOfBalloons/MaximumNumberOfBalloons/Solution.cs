namespace MaximumNumberOfBalloons;

public class Solution
{
    public int MaxNumberOfBalloons(string text)
    {
        var hs = new HashSet<char>() { 'b', 'a', 'l', 'o', 'n' };
        var freq = new Dictionary<char, int>();
        for (int i = 0; i < text.Length; i++)
        {
            if (hs.Contains(text[i]))
            {
                freq[text[i]] = freq.GetValueOrDefault(text[i], 0) + 1;
            }
        }

        if (freq.Count < hs.Count)
        {
            return 0;
        }
        
        var singles = new HashSet<char>() { 'b', 'a', 'n' };
        var doubles = new HashSet<char>() { 'l', 'o', };

        var minSingle = int.MaxValue;
        var minDouble = int.MaxValue;

        foreach (var (key, count) in freq)
        {
            if (singles.Contains(key) && count < minSingle)
            {
                minSingle = count;
            }
            else if (doubles.Contains(key) && count < minDouble)
            {
                minDouble = count;
            }
        }

        minDouble /= 2;

        return minSingle < minDouble ? minSingle : minDouble;
    }
}