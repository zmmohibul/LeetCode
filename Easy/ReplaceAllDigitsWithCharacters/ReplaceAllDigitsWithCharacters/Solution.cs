using System.Text;

namespace ReplaceAllDigitsWithCharacters;

public class Solution
{
    public string ReplaceDigits(string s)
    {
        var sb = new StringBuilder();
        int i;
        for (i = 0; i < s.Length - 1; i += 2)
        {
            var c = s[i];
            sb.Append(c);
            
            int ci = s[i + 1];
            ci = c + ci - 48;
            sb.Append((char)ci);
        }

        if (i < s.Length)
        {
            sb.Append(s[i]);
        }

        return sb.ToString();
    }
}