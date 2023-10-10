using System.Text;

namespace DeleteCharactersToMakeFancyString;

public class Solution 
{
    public string MakeFancyString(string s) 
    {
        if (s.Length < 3)
        {
            return s;
        }

        var sb = new StringBuilder();
        sb.Append(s[0]);
        sb.Append(s[1]);
        for (int i = 2; i < s.Length; i++)
        {
            if (sb[^1] == s[i] && sb[^2] == s[i])
            {
                continue;
            }

            sb.Append(s[i]);
        }
        
        return sb.ToString();
    }
}