using System.Text;

namespace ReverseWordsInString;

public class Solution {
    public string ReverseWords(string s)
    {
        var words = s.Split(' ');
        var sb = new StringBuilder();
        for (int i = words.Length - 1; i >= 0; i--)
        {
            if (!string.IsNullOrWhiteSpace(words[i]))
            {
                sb.Append(words[i]);
                sb.Append(' ');
            }
        }

        sb.Remove(sb.Length - 1, 1);

        return sb.ToString();
    }
}