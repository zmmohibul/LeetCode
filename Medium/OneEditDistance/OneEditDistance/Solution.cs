namespace OneEditDistance;

public class Solution 
{
    public bool IsOneEditDistance(string s, string t) 
    {
        if (s.Length - 1 != t.Length || s.Length + 1 != t.Length || s.Length != t.Length || s.Equals(t))
        {
            return false;
        }

        var sFreq = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++)
        {
            var c = s[i];
            sFreq[c] = sFreq.GetValueOrDefault(c, 0) + 1;
        }
        
        var tFreq = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++)
        {
            var c = t[i];
            tFreq[c] = tFreq.GetValueOrDefault(c, 0) + 1;
        }

        int count = 0;
        foreach (var (c, cnt) in sFreq)
        {
            if (!tFreq.ContainsKey(c))
            {
                count += 1;
            }
            else
            {
                count = Math.Abs(tFreq[c] - cnt);
            }

            if (count > 1)
            {
                return false;
            }
        }

        return true;
    }
}