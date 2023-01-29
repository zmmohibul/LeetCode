using System.Text;

namespace DecryptStringFromAlphabetToIntegerMapping;

public class Solution
{
    public string FreqAlphabets(string s)
    {
        var atoiMap = new Dictionary<char, char>();
        var ch = 'a';
        for (char i = '1'; i <= '9'; i++)
        {
            atoiMap[i] = ch;
            ch++;
        }

        var jtozMap = new Dictionary<string, char>();
        for (int i = 10; i <= 26; i++)
        {
            var si = Convert.ToString(i);
            jtozMap[si] = ch;
            ch++;
        }

        var sb = new StringBuilder();
        for (int i = 0; i < s.Length - 2; i++)
        {
            if (s[i + 2] == '#')
            {
                var ss = new StringBuilder();
                ss.Append(s[i]);
                ss.Append(s[i + 1]);
                sb.Append(jtozMap[ss.ToString()]);
                i += 2;
            }
            else
            {
                sb.Append(atoiMap[s[i]]);
            }
        }

        if (s[s.Length - 1] != '#')
        {
            if (s[s.Length - 2] != '#')
            {
                sb.Append(atoiMap[s[s.Length - 2]]);
            }
            sb.Append(atoiMap[s[s.Length - 1]]);
        }

        return sb.ToString();
    }
}