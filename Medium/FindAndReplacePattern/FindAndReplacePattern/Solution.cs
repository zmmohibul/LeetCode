namespace FindAndReplacePattern;

public class Solution
{
    public List<string> FindAndReplacePattern(string[] words, string pattern)
    {
        var result = new List<string>();
        for (int i = 0; i < words.Length; i++)
        {
            var word = words[i];
            if (DoesPatternMatch(word, pattern) && DoesPatternMatch(pattern, word))
            {
                result.Add(word);
            }
        }
        return result;
    }

    public bool DoesPatternMatch(string str1, string str2)
    {
        var map = new Dictionary<char, char>();
        for (int i = 0; i < str1.Length; i++)
        {
            if (!map.ContainsKey(str2[i]))
            {
                map[str2[i]] = str1[i];
            }

            if (map[str2[i]] != str1[i])
            {
                return false;
            }
        }

        return true;
    }
}