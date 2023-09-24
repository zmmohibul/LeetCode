namespace LongestStringChain;

public class Solution 
{
    private Dictionary<string, int> wordChains = new Dictionary<string, int>();

    public int LongestStrChain(string[] words)
    {
        var wordsGroupedByLength = new Dictionary<int, HashSet<string>>();
        foreach (var word in words)
        {
            var length = word.Length;
            if (!wordsGroupedByLength.ContainsKey(length))
            {
                wordsGroupedByLength[length] = new HashSet<string>();
            }

            wordsGroupedByLength[length].Add(word);
        }
        
        var chains = new HashSet<int>();
        foreach (var word in words)
        {
            chains.Add(LongestStrChainHelper(wordsGroupedByLength, word));
        }

        return chains.Max();
    }
    
    private int LongestStrChainHelper(Dictionary<int, HashSet<string>> wordGroups, string currWord) 
    {
        if (wordChains.ContainsKey(currWord))
        {
            return wordChains[currWord];
        }
        
        if (currWord.Length == 1)
        {
            wordChains[currWord] = 1;
            return 1;
        }
        
        var chains = new HashSet<int>(){1};
        if (wordGroups.ContainsKey(currWord.Length - 1))
        {
            var wordsToExplore = wordGroups[currWord.Length - 1];
            foreach (var word in wordsToExplore)
            {
                if (word.Length == currWord.Length - 1)
                {
                    if (IsPredecessor(currWord, word))
                    {
                        chains.Add(1 + LongestStrChainHelper(wordGroups, word));
                    }
                }
            }
        }

        var max = chains.Max();
        wordChains[currWord] = max;
        return max;
    }

    private bool IsPredecessor(string big, string small)
    {
        var bi = 0;
        var si = 0;
        var mismatch = 0;
        while (si < small.Length)
        {
            if (big[bi] == small[si])
            {
                si++;
            }
            else
            {
                mismatch++;
                if (mismatch > 1)
                {
                    break;
                }
            }
            bi++;
        }

        return mismatch < 2;
    }
}