namespace ValidAnagram;

public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }
        
        var sFreq = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++)
        {
            sFreq[s[i]] = sFreq.GetValueOrDefault(s[i], 0) + 1;
        }

        var tFreq = new Dictionary<char, int>();
        for (int i = 0; i < t.Length; i++)
        {
            if (!sFreq.ContainsKey(t[i]))
            {
                return false;
            }

            tFreq[t[i]] = tFreq.GetValueOrDefault(t[i], 0) + 1;
        }

        for (int i = 0; i < tFreq.Count; i++)
        {
            var item = tFreq.ElementAt(i);
            if (sFreq[item.Key] != tFreq[item.Key])
            {
                return false;
            }
        }

        return true;
    }
}