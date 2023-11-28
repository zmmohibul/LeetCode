namespace MinimumAddToMakeParenthesesValid;

public class Solution 
{
    public int MinAddToMakeValid(string s) 
    {
        var i = 0;
        var steps = 0;
        var leftCount = 0;
        var rightCount = 0;
        while (i < s.Length)
        {
            while (i < s.Length && s[i] == '(')
            {
                i++;
                leftCount++;
            }

            while (i < s.Length && s[i] == ')')
            {
                i++;
                rightCount++;
            }

            if (rightCount >= leftCount)
            {
                steps += (rightCount - leftCount);
                rightCount = 0;
                leftCount = 0;
            }
            else
            {
                leftCount -= rightCount;
                rightCount = 0;
            }
        }

        if (leftCount > 0)
        {
            steps += (Math.Abs(rightCount - leftCount));
        }
        
        return steps;
    }
}