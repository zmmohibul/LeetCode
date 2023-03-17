using System.Text;

namespace GenerateStringWithCharactersThatHaveOddCounts;

public class Solution
{
    public string GenerateTheString(int n)
    {
        var sb = new StringBuilder();
        if (n % 2 == 0)
        {
            sb.Append('a');
            n -= 1;
        }

        for (int i = 0; i < n; i++)
        {
            sb.Append('b');
        }

        return sb.ToString();
    }
}