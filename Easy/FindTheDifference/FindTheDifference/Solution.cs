namespace FindTheDifference;

public class Solution
{
    public char FindTheDifference(string s, string t)
    {
        var sFreq = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++)
        {
            if (!sFreq.ContainsKey(s[i]))
            {
                sFreq[s[i]] = 1;
            }
            else
            {
                sFreq[s[i]]++;
            }
        }

        var tFreq = new Dictionary<char, int>();
        for (int i = 0; i < t.Length; i++)
        {
            if (!tFreq.ContainsKey(t[i]))
            {
                tFreq[t[i]] = 1;
            }
            else
            {
                tFreq[t[i]]++;
            }
        }

        for (int i = 0; i < tFreq.Count; i++)
        {
            var item = tFreq.ElementAt(i);
            if (!sFreq.ContainsKey(item.Key) || sFreq[item.Key] != item.Value)
            {
                return item.Key;
            }
        }

        return 'a';
    }
}