using System.Text;

namespace ReverseWordsInStringIII;

public class Solution
{
    public string ReverseWords(string s)
    {
        var sb = new StringBuilder(s);
        var i = 0;
        var j = 0;
        while (j < sb.Length)
        {
            while (j < sb.Length && sb[j] != ' ')
            {
                j++;
            }

            Console.WriteLine(j);

            var tj = j;
            j--;
            
            while (i < j)
            {
                (sb[i], sb[j]) = (sb[j], sb[i]);
                
                i++;
                j--;
            }

            tj++;
            i = tj;
            j = tj;
        }

        return sb.ToString();
    }
}