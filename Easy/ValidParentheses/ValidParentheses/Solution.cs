namespace ValidParentheses;

public class Solution
{
    public static bool IsValid(string s)
    {
        var open = new HashSet<char>() { '(', '{', '[' };
        var close = new HashSet<char>() { ')', '}', ']' };

        var match = new Dictionary<char, char>();
        match['('] = ')';
        match['{'] = '}';
        match['['] = ']';

        var stack = new Stack<char>();
        for (int i = 0; i < s.Length; i++)
        {
            var ch = s[i];
            if (open.Contains(ch))
            {
                stack.Push(ch);
            }
            else
            {
                if (stack.Count == 0)
                {
                    return false;
                }
                var last = stack.Pop();
                var lastCl = match[last];

                if (ch != lastCl)
                {
                    return false;
                }
            }
        }

        if (stack.Count > 0)
        {
            return false;
        }

        return true;
    }
}