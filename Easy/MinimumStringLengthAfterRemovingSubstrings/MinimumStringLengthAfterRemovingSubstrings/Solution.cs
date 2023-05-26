using System.Text;

namespace MinimumStringLengthAfterRemovingSubstrings;

public class Solution
{
    public int MinLength(string s)
    {
        var stack = new Stack<char>();
        var i = 0;
        while (i < s.Length)
        {
            var c = s[i];
            if (stack.Count > 0)
            {
                var last = stack.Pop();
                var str = $"{last}{c}";
                if (!str.Equals("AB") && !str.Equals("CD"))
                {
                    stack.Push(last);
                    stack.Push(c);
                }
            }
            else
            {
                stack.Push(c);
            }
            i++;
        }
        
        return stack.Count;
    }
}