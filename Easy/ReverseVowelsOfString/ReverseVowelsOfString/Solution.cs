using System.Text;

namespace ReverseVowelsOfString;

public class Solution
{
    public string ReverseVowels(string s)
    {
        var vowels = new HashSet<char>() { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        var revVowels = new StringBuilder();
        for (int i = s.Length - 1; i > -1; i--)
        {
            if (vowels.Contains(s[i]))
            {
                revVowels.Append(s[i]);
            }
        }

        int j = 0;
        var sb = new StringBuilder(s);
        for (int i = 0; i < sb.Length; i++)
        {
            if (vowels.Contains(sb[i]))
            {
                sb[i] = revVowels[j];
                j++;
            }
        }

        return sb.ToString();
    }
}