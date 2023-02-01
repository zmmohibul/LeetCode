using System.Text;

namespace GreatestCommonDivisorOfStrings;

public class Solution
{
    public string GcdOfStrings(string str1, string str2)
    {
        var gcdLength = 0;
        var s1Len = str1.Length;
        var s2Len = str2.Length;
        for (int i = 1; i <= str1.Length; i++)
        {
            if (s1Len % i == 0 && s2Len % i == 0)
            {
                gcdLength = i;
            }
        }

        var gcd = new StringBuilder();
        for (int i = 0; i < gcdLength; i++)
        {
            if (str1[i] == str2[i])
            {
                gcd.Append(str1[i]);
            }
            else
            {
                return "";
            }
        }

        var gcds = gcd.ToString();
        Console.WriteLine(gcds);
        if (gcds.Length == 0)
        {
            return "";
        }
        
        var j = 0;
        var l = 0;
        while (j < str1.Length)
        {
            if (str1[j] != gcds[l])
            {
                return "";
            }

            j++;
            if (l + 1 == gcds.Length)
            {
                l = 0;
            }
            else
            {
                l++;
            }
        }
        
        var k = 0;
        l = 0;
        while (k < str2.Length)
        {
            if (str2[k] != gcds[l])
            {
                return "";
            }

            k++;
            if (l + 1 == gcds.Length)
            {
                l = 0;
            }
            else
            {
                l++;
            }
        }

        return gcds;
    }
}