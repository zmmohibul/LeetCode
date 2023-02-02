namespace VerifyingAlienDictionary;

public class Solution
{
    public bool IsAlienSorted(string[] words, string order)
    {
        var orderMap = new Dictionary<char, int>();
        for (int i = 0; i < order.Length; i++)
        {
            orderMap[order[i]] = i + 1;
        }

        for (int i = 0; i < words.Length - 1; i++)
        {
            var word1 = words[i];
            var word2 = words[i + 1];
            
            if (word1.StartsWith(word2[0]))
            {
                var lastc1 = 'a';
                var lastc2 = 'a';
                for (int j = 0; j < word1.Length && j < word2.Length; j++)
                {
                    if (orderMap[word1[j]] > orderMap[word2[j]])
                    {
                        return false;
                    }

                    lastc1 = word1[j];
                    lastc2 = word2[j];
                }

                if (lastc1 == lastc2 && word1.Length > word2.Length)
                {
                    return false;
                }
            }
            else
            {
                if (orderMap[word1[0]] > orderMap[word2[0]])
                {
                    return false;
                }
            }
        }

        return true;
    }
}