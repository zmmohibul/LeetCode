using System.Text;

namespace LexicographicallySmallestPalindrome;

public class Solution
{
    public string MakeSmallestPalindrome(string s)
    {
        var sb = new StringBuilder(s);
        var i = 0;
        var j = sb.Length - 1;
        while (i < j)
        {
            if (s[i] != sb[j])
            {
                if (sb[i] < sb[j])
                {
                    sb[j] = sb[i];
                }
                else
                {
                    sb[i] = sb[j];
                }
            }

            i++;
            j--;
        }

        return sb.ToString();
    }
}