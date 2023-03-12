namespace MaximumNestingDepthOfParentheses;

public class Solution
{
    public int MaxDepth(string s)
    {
        int currDepth = 0;
        int maxDepth = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
            {
                currDepth++;
                if (currDepth > maxDepth)
                {
                    maxDepth = currDepth;
                }
            }
            else if (s[i] == ')')
            {
                currDepth--;
            }
        }

        return maxDepth;
    }
}