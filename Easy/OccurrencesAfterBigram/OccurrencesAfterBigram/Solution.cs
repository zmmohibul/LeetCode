using System.Text;

namespace OccurrencesAfterBigram;

public class Solution 
{
    public string[] FindOcurrences(string text, string first, string second) 
    {
        var wordsInText = SplitText(text).ToList();

        var result = new List<string>();
        var i = 0;
        while (i < wordsInText.Count - 2)
        {
            if (AreStringsEqual(wordsInText[i], first) && AreStringsEqual(wordsInText[i + 1], second))
            {
                result.Add(wordsInText[i + 2]);
            }

            i++;
        }

        return result.ToArray();
    }

    public IEnumerable<string> SplitText(string text)
    {
        var i = 0;
        while (i < text.Length)
        {
            var sb = new StringBuilder();
            while (i < text.Length && text[i] != ' ')
            {
                sb.Append(text[i]);
                i++;
            }
            
            i++;
            yield return sb.ToString();
        }
    }

    public bool AreStringsEqual(string s1, string s2)
    {
        if (s1.Length != s2.Length)
        {
            return false;
        }
        
        for (int j = 0; j < s1.Length; j++)
        {
            if (s1[j] != s2[j])
            {
                return false;
            }
        }

        return true;
    }
}