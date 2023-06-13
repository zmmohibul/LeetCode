using System.Text;

namespace SubdomainVisitCount;

public class Solution
{
    public IList<string> SubdomainVisits(string[] cpdomains)
    {
        var dict = new Dictionary<string, int>();
        for (int i = 0; i < cpdomains.Length; i++)
        {
            var pair = cpdomains[i];
            var j = 0;
            var num = 0;
            while (pair[j] != ' ')
            {
                num *= 10;
                num += (pair[j] - '0');
                j++;
            }
            // Console.WriteLine(num);
            j = pair.Length - 1;
            var k = j;
            var sb = new StringBuilder();
            while (pair[j] != ' ')
            {
                k = j;
                while (pair[k] != '.')
                {
                    if (pair[k] == ' ')
                    {
                        k++;
                        break;
                    }

                    sb.Insert(0, pair[k]);
                    // sb.Append(pair[k]);
                    k--;
                }
                // Console.WriteLine(sb);

                var s = sb.ToString();
                dict[s] = dict.GetValueOrDefault(s, 0) + num;
                sb.Insert(0, pair[k]);
                // sb.Append(pair[k]);
                
                k--;
                j = k;
                
            }
        }

        var result = new List<string>();
        foreach (var (key, value) in dict)
        {
            result.Add($"{value} {key}");
        }

        return result;
    }
}