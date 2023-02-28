namespace IsomorphicStrings;

public class Solution
{
    public bool IsIsomorphic(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }
        
        var sToTCharMap = new Dictionary<char, char>();
        for (int i = 0; i < s.Length; i++)
        {
            if (sToTCharMap.ContainsKey(s[i]))
            {
                if (t[i] != sToTCharMap[s[i]])
                {
                    return false;
                }
            }
            else
            {
                sToTCharMap[s[i]] = t[i];
            }
        }
        
        var tToSCharMap = new Dictionary<char, char>();
        for (int i = 0; i < s.Length; i++)
        {
            if (tToSCharMap.ContainsKey(t[i]))
            {
                if (s[i] != tToSCharMap[t[i]])
                {
                    return false;
                }
            }
            else
            {
                tToSCharMap[t[i]] = s[i];
            }
        }

        return true;
    }
}