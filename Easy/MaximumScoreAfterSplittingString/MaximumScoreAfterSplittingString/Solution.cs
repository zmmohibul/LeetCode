namespace MaximumScoreAfterSplittingString;

public class Solution
{
    public int MaxScore(string s)
    {
        var zeros = new int[s.Length];
        int count = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '0')
            {
                count += 1;
            }

            zeros[i] = count;
        }

        count = 0;
        int max = 0;
        for (int i = s.Length - 1; i > 0; i--)
        {
            if (s[i] == '1')
            {
                count += 1;
            }

            int oneZeroCount = count + zeros[i - 1];
            if (oneZeroCount > max)
            {
                max = oneZeroCount;
            }
        }

        return max;
    }
}