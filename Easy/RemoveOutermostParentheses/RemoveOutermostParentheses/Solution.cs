using System.Text;

namespace RemoveOutermostParentheses;

public class Solution 
{
    public static string RemoveOuterParentheses(string s) {
        var sb = new StringBuilder();
        var cnt = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] ==')')
            {
                cnt--;
            }

            if (cnt != 0)
            {
                sb.Append(s[i]);
            }

            if (s[i] == '(')
            {
                cnt++;
            }
        }

        return sb.ToString();
    }
}