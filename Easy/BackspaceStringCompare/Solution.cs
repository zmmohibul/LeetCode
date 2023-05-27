using System.Text;

namespace BackspaceStringCompare;

public class Solution
{
    public bool BackspaceCompare(string s, string t)
    {
        return RemoveBackspaceFromString(s).Equals(RemoveBackspaceFromString(t));
    }

    public string RemoveBackspaceFromString(string s)
    {
        var sb = new StringBuilder();
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '#' && sb.Length > 0)
            {
                sb.Remove(sb.Length - 1, 1);
            }
            else if (s[i]  != '#')
            {
                sb.Append(s[i]);
            }
        }

        return sb.ToString();
    }
}