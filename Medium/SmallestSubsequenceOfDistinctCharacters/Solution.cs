using System.Text;

namespace SmallestSubsequenceOfDistinctCharacters;

public class Solution {
    public string SmallestSubsequence(string s) {
        var lastOccurence = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++)
        {
            lastOccurence[s[i]] = i;
        }

        var stack = new Stack<char>();
        var seen = new HashSet<char>();
        for (int i = 0; i < s.Length; i++)
        {
            if (seen.Contains(s[i])) continue;

            while (stack.Count > 0)
            {
                if (s[i] < stack.Peek() && lastOccurence[stack.Peek()] > i)
                {
                    seen.Remove(stack.Pop());

                }
                else
                {
                    break;
                }
            }

            stack.Push(s[i]);
            seen.Add(s[i]);
        }

        var sb = new StringBuilder();
        foreach (var c in stack)
        {
            sb.Insert(0, c);
        }
        return sb.ToString();
    }
}