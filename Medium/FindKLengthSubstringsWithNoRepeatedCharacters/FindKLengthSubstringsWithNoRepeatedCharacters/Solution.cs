using System.Text;

namespace FindKLengthSubstringsWithNoRepeatedCharacters;

public class Solution
{
    public int NumKLenSubstrNoRepeats(string s, int k)
    {
        if (s.Length < k)
        {
            return 0;
        }
        
        var i = 0;
        var hs = new HashSet<char>();
        var sb = new StringBuilder();
        while (i < k)
        {
            sb.Append(s[i]);
            hs.Add(s[i]);
            i++;
        }

        var result = 0;
        if (hs.Count == k)
        {
            result++;
        }

        var j = k;
        while (j < s.Length)
        {
            sb.Remove(0, 1);
            sb.Append(s[j]);

            hs = new HashSet<char>();
            for (int l = 0; l < sb.Length; l++)
            {
                hs.Add(sb[l]);
            }
            
            if (hs.Count == k)
            {
                result++;
            }

            j++;
        }

        return result;
    }
}