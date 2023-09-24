namespace LongestStringChain;

public class Solution 
{
    Dictionary<string, int> wordChains = new Dictionary<string, int>();

    public int LongestStrChain(string[] words) 
    {
        var chains = new HashSet<int>();
        foreach (var word in words)
        {
            chains.Add(LongestStrChainHelper(words, word));
        }

        return chains.Max();
    }

    private int LongestStrChainHelper(string[] words, string currWord) 
    {
        if (wordChains.ContainsKey(currWord))
        {
            return wordChains[currWord];
        }
        else if (currWord.Length == 1)
        {
            return 1;
        }
        else
        {
            var chains = new HashSet<int>(){1};
            foreach (var word in words)
            {
                if (word.Length == currWord.Length - 1)
                {
                    if (IsPredecessor(currWord, word))
                    {
                        chains.Add(1 + LongestStrChainHelper(words, word));
                    }
                }
            }

            var max = chains.Max();
            wordChains[currWord] = max;
            return max;
        }
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