using System.Text;

namespace DivideStringIntoGroupsOfSizeK;

public class Solution 
{
    public string[] DivideString(string s, int k, char fill) 
    {
        var size = s.Length / k;
        if (s.Length % k != 0)
        {
            size++;
        }
        var result = new string[size];

        var j = 0;
        for (int i = 0; i < result.Length; i++)
        {
            var word = new StringBuilder();
            var l = 0;
            while (j < s.Length && l < k)
            {
                word.Append(s[j]);
                j++;
                l++;
            }

            if (l < k)
            {
                while (l < k)
                {
                    word.Append(fill);
                    l++;
                }
            }

            result[i] = word.ToString();
        }

        return result;
    }
}