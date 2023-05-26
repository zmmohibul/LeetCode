using System.Text;

namespace MinimumStringLengthAfterRemovingSubstrings;

public class Solution
{
    public int MinLength(string s)
    {
        var sb = new StringBuilder(s);
        var i = 0;
        while (i < sb.Length - 1)
        {
            var str = $"{sb[i]}{sb[i + 1]}";
            if (str.Equals("AB") || str.Equals("CD"))
            {
                sb.Remove(i, 2);
                i = 0;
            }
            else
            {
                i++;
            }
        }

        return sb.Length;
    }
}