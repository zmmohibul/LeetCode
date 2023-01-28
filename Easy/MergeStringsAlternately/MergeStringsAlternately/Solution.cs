using System.Text;

namespace MergeStringsAlternately;

public class Solution
{
    public string MergeAlternately(string word1, string word2)
    {
        var result = new StringBuilder();
        int i = 0;
        while (i < word1.Length && i < word2.Length)
        {
            result.Append(word1[i]);
            result.Append(word2[i]);
            i++;
        }

        if (i < word2.Length)
        {
            word1 = word2;
        }

        while (i < word1.Length)
        {
            result.Append(word1[i]);
            i++;
        }

        return result.ToString();
    }
}