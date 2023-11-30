namespace GroupsOfSpecialEquivalentStrings;

public class Solution 
{
    public int NumSpecialEquivGroups(string[] words) 
    {
        var processed = new HashSet<string>();
        var count = 0;
        for (var i = 0; i < words.Length; i++)
        {
            if (processed.Contains(words[i])) continue;
            
            for (var j = i + 1; j < words.Length; j++)
            {
                if (IsEquivalent(words[i], words[j]))
                {
                    processed.Add(words[j]);
                }
            }

            processed.Add(words[i]);
            count++;
        }
        
        return count;
    }

    private bool IsEquivalent(string w1, string w2)
    {
        var w1EvenIndicesFreq = new Dictionary<char, int>();
        var w1OddIndicesFreq = new Dictionary<char, int>();

        var w2EvenIndicesFreq = new Dictionary<char, int>();
        var w2OddIndicesFreq = new Dictionary<char, int>();

        for (var i = 0; i < w1.Length; i++)
        {
            if (i % 2 == 0)
            {
                w1EvenIndicesFreq[w1[i]] = w1EvenIndicesFreq.GetValueOrDefault(w1[i]) + 1;
                w2EvenIndicesFreq[w2[i]] = w2EvenIndicesFreq.GetValueOrDefault(w2[i]) + 1;
            }
            else
            {
                w1OddIndicesFreq[w1[i]] = w1OddIndicesFreq.GetValueOrDefault(w1[i]) + 1;
                w2OddIndicesFreq[w2[i]] = w2OddIndicesFreq.GetValueOrDefault(w2[i]) + 1;
            }
        }

        return CharFreqDictionaryEqual(w1EvenIndicesFreq, w2EvenIndicesFreq)
               && CharFreqDictionaryEqual(w1OddIndicesFreq, w2OddIndicesFreq);
    }

    private bool CharFreqDictionaryEqual(IReadOnlyDictionary<char, int> d1, IReadOnlyDictionary<char, int> d2)
    {
        if (d1.Count != d2.Count) return false;
        
        foreach (var (c, count) in d1)
        {
            if (count != d2.GetValueOrDefault(c))
            {
                return false;
            }
        }

        return true;
    }
}