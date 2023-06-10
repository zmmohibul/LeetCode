using System.Text;

namespace RemovingStarsFromString;

public class Solution
{
    public string RemoveStars(string s)
    {
        var sb = new StringBuilder();
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '*')
            {
                sb.Remove(sb.Length - 1, 1);
            }
            else
            {
                sb.Append(s[i]);
            }
        }

        return sb.ToString();
    }
}