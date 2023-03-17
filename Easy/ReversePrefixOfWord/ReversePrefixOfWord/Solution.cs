using System.Text;

namespace ReversePrefixOfWord;

public class Solution
{
    public string ReversePrefix(string word, char ch)
    {
        var ind = -1;
        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] == ch)
            {
                ind = i;
                break;
            }
        }

        if (ind == -1)
        {
            return word;
        }

        var sb = new StringBuilder();
        var revInd = ind + 1;
        while (ind > -1)
        {
            sb.Append(word[ind]);
            ind--;
        }

        while (revInd < word.Length)
        {
            sb.Append(word[revInd]);
            revInd++;
        }

        return sb.ToString();
    }
}