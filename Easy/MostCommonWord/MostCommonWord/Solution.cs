using System.Text;

namespace MostCommonWord;

public class Solution 
{
    public string MostCommonWord(string paragraph, string[] banned) {
        var bannedSet = new HashSet<string>();
        foreach (var word in banned)
        {
            bannedSet.Add(word);
        }
        
        var wordCount = new Dictionary<string, int>();
        var seperator = new HashSet<char>{' ', '\'', ',', '.', ';', '?', '!'};
        var i = 0;
        while (i < paragraph.Length)
        {
            var sb = new StringBuilder();
            while (i < paragraph.Length && !seperator.Contains(paragraph[i]))
            {
                sb.Append(Char.ToLower(paragraph[i]));
                i++;
            }

            var str = sb.ToString();
            if (!string.IsNullOrEmpty(str) && !bannedSet.Contains(str))
            {
                wordCount[str] = wordCount.GetValueOrDefault(str, 0) + 1;
            }

            i++;
        }

        var maxCount = wordCount.Values.Max();
        foreach (var (word, count) in wordCount)
        {
            if (count == maxCount)
            {
                return word;
            }
        }
        
        return "";
    }
}