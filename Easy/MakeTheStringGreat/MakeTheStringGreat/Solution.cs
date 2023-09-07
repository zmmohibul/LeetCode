using System.Text;

namespace MakeTheStringGreat;

public class Solution
{
    public string MakeGood(string s) 
    {
        var sb = new StringBuilder();
        for (int i = 0; i < s.Length; i++)
        {
            var currChar = (int) s[i];

            var prevChar = 0;
            if (sb.Length > 0)
            {
                prevChar = (int) sb[^1];
            }

            if (Math.Abs(prevChar - currChar) == 32)
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