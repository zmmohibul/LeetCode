namespace OneEditDistance;

public class Solution 
{
    public bool IsOneEditDistance(string s, string t) 
    {
        if ((s.Length - 1 != t.Length && s.Length + 1 != t.Length && s.Length != t.Length) || s.Equals(t))
        {
            return false;
        }

        int i = 0;
        int j = 0;
        int count = 0;
        while (i < s.Length && j < t.Length)
        {
            if (s.Length < t.Length)
            {
                if (s[i] == t[j])
                {
                    i += 1;
                }
                else
                {
                    count += 1;
                }

                j += 1;

            }
            else if (t.Length < s.Length)
            {
                if (s[i] == t[j])
                {
                    j += 1;
                }
                else
                {
                    count += 1;
                }
                i += 1;
            }
            else
            {
                if (s[i] != t[j])
                {
                    count += 1;
                }

                i += 1;
                j += 1;
            }

            if (count > 1)
            {
                return false;
            }
        }

        return true;
    }
}