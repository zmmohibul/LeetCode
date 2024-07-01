using System.Text;

namespace ClearDigits;

public class Solution 
{
    public string ClearDigits(string s) 
    {
        var sb = new StringBuilder();
        foreach (var c in s)
        {
            if (c >= '0' && c <= '9' && sb.Length > 0)
            {
                sb.Remove(sb.Length - 1, 1);
            }
            else
            {
                sb.Append(c);
            }
        }
        
        return sb.ToString();
    }
}