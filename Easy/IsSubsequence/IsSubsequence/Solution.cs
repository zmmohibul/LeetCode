namespace IsSubsequence;

public class Solution
{
    public bool IsSubsequence(string s, string t)
    {
        if (s.Length == 0)
        {
            return true;
        }

        if (s.Length > t.Length)
        {
            return false;
        }
        
        var lookingFor = s[0];
        int i = 0;
        for (int j = 0; j < t.Length; j++)
        {
            if (t[j] == lookingFor)
            {
                i++;

                if (i == s.Length)
                {
                    return true;
                }

                lookingFor = s[i];
            }
        }

        return false;
    }
}