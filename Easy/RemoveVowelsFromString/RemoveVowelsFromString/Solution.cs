using System.Text;

namespace RemoveVowelsFromString;

public class Solution
{
    public string RemoveVowels(string s)
    {
        var vowels = new HashSet<char>() { 'a', 'e', 'i', 'o', 'u' };
        var sb = new StringBuilder(s);
        for (int i = 0; i < sb.Length; i++)
        {
            if (vowels.Contains(sb[i]))
            {
                sb.Remove(i, 1);
                i--;
            }
        }

        return sb.ToString();
    }
}