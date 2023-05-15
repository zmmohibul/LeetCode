namespace CheckWhetherTwoStringsAreAlmostEquivalent;

public class Solution
{
    public bool CheckAlmostEquivalent(string word1, string word2)
    {
        var freqWord1 = new Dictionary<char, int>();
        for (int i = 0; i < word1.Length; i++)
        {
            freqWord1[word1[i]] = freqWord1.GetValueOrDefault(word1[i], 0) + 1;
        }
        
        var freqWord2 = new Dictionary<char, int>();
        for (int i = 0; i < word1.Length; i++)
        {
            freqWord2[word2[i]] = freqWord2.GetValueOrDefault(word2[i], 0) + 1;
        }

        foreach (var (ch, count) in freqWord1)
        {
            if (
                (freqWord2.ContainsKey(ch) && Math.Abs(freqWord2[ch] - count) > 3)
                || (!freqWord2.ContainsKey(ch) && count > 3)
            )
            {
                return false;
            }
        }
        
        foreach (var (ch, count) in freqWord2)
        {
            if (
                (freqWord1.ContainsKey(ch) && Math.Abs(freqWord1[ch] - count) > 3)
                || (!freqWord1.ContainsKey(ch) && count > 3)
            )
            {
                return false;
            }
        }

        return true;
    }
}