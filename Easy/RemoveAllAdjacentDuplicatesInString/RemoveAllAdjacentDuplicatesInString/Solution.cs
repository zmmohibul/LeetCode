using System.Text;

namespace RemoveAllAdjacentDuplicatesInString;

public class Solution 
{
    public string RemoveDuplicates(string s)
    {
        var stack = new Stack<char>();
        for (int i = 0; i < s.Length; i++)
        {
            var c = s[i];
            if (stack.Count > 0)
            {
                var last = stack.Pop();
                if (last != c)
                {
                    stack.Push(last);
                    stack.Push(c);
                }
            }
            else
            {
                stack.Push(c);
            }
        }

        var sb = new StringBuilder();
        while (stack.Count > 0)
        {
            sb.Append(stack.Pop());
        }

        var j = 0;
        var k = sb.Length - 1;
        while (j < k)
        {
            (sb[j], sb[k]) = (sb[k], sb[j]);
            j++;
            k--;
        }
        
        return sb.ToString();
    }
}