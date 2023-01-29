using System.Text;

namespace ToLowerCase;

public class Solution
{
    public string ToLowerCase(string s) 
    {
        var sb = new StringBuilder();
        for (int i = 0; i < s.Length; i++)
        {
            var c = (int) s[i];
            if (c >= 65 && c <= 90)
            {
                c += 32;
            }
            sb.Append((char) c);
        }
        return sb.ToString();
    }
}