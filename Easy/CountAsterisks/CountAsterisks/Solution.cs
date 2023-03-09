namespace CountAsterisks;

public class Solution
{
    public int CountAsterisks(string s)
    {
        var insideVerticalBarPair = false;
        var count = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '|' && !insideVerticalBarPair)
            {
                insideVerticalBarPair = true;
                continue;
            }

            if (s[i] == '|' && insideVerticalBarPair)
            {
                insideVerticalBarPair = false;
                continue;
            }

            if (s[i] == '*' && !insideVerticalBarPair)
            {
                count++;
            }
        }

        return count;
    }
}