using System.Text;

namespace LargestPalindromicNumber;

public class Solution
{
    public string LargestPalindromic(string num)
    {
        var freq = new SortedDictionary<char, int>();
        foreach (var n in num)
        {
            freq[n] = freq.GetValueOrDefault(n) + 1;
        }

        var sb = new StringBuilder();
        foreach (var (n, count) in freq)
        {
            var appendCount = count / 2;
            sb.Append(n, appendCount);
            sb.Insert(0, n.ToString(), appendCount);
        }

        for (var i = freq.Count - 1; i > -1; i--)
        {
            if (freq.ElementAt(i).Value % 2 != 0)
            {
                sb.Insert(sb.Length / 2, freq.ElementAt(i).Key);
                break;
            }
        }
        
        if (sb[0] == '0')
        {
            var leadingZeroCount = 0;
            for (var i = 0; i < sb.Length && sb[i] == '0'; i++)
            {
                leadingZeroCount++;
            }

            if (leadingZeroCount == sb.Length) return "0";

            sb.Remove(0, leadingZeroCount);
            sb.Remove(sb.Length - leadingZeroCount, leadingZeroCount);
        }

        return sb.ToString();
    }
}