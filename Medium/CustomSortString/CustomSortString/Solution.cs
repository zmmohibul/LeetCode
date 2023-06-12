using System.Text;

namespace CustomSortString;

public class Solution
{
    public string CustomSortString(string order, string s)
    {
        var charFreq = new Dictionary<char, int>();
        foreach (var c in s)
        {
            charFreq[c] = charFreq.GetValueOrDefault(c, 0) + 1;
        }

        var sb = new StringBuilder();
        foreach (var c in order)
        {
            if (charFreq.ContainsKey(c))
            {
                sb.Append(c, charFreq[c]);
            }

            charFreq.Remove(c);
        }

        foreach (var (c, count) in charFreq)
        {
            sb.Append(c, count);
        }

        return sb.ToString();
    }
}