namespace SeparateBlackAndWhiteBalls;

public class Solution 
{
    public long MinimumSteps(string s) 
    {
        var left = 0;
        var right = 0;
        long steps = 0;
        for (right = 0; right < s.Length; right++)
        {
            if (s[right] == '0')
            {
                steps += (right - left);
                left++;
            }
        }

        return steps;
    }
}