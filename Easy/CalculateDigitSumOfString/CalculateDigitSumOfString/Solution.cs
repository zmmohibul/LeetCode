using System.Text;

namespace CalculateDigitSumOfString;

public class Solution
{
    public string DigitSum(string s, int k)
    {
        var sb = new StringBuilder(s);
        Console.WriteLine(sb);
        while (sb.Length > k)
        {
            var num = 0;
            var tsb = new StringBuilder();
            var n = sb.Length / k;
            var l = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    num += (sb[l] - '0');
                    l++;
                }

                tsb.Append(num);
                num = 0;
            }



            if (l < sb.Length)
            {
                while (l < sb.Length)
                {
                    num += (sb[l] - '0');
                    l++;
                }
                tsb.Append(num);
            }

            sb = tsb;
            Console.WriteLine(sb);
        }

        return sb.ToString();
    }
}