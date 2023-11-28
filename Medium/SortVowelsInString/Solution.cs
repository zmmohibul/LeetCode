using System.Text;

namespace SortVowelsInString;

public class Solution 
{
    public string SortVowels(string s) 
    {
        var vowels = new HashSet<char>{ 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        var vowelsInS = new List<char>();
        foreach (var c in s)
        {
            if (vowels.Contains(c))
            {
                vowelsInS.Add(c);
            }
        }

        vowelsInS.Sort();

        var vowInd = 0;
        var result = new StringBuilder();
        foreach (var c in s)
        {
            if (vowels.Contains(c))
            {
                result.Append(vowelsInS[vowInd]);
                vowInd++;
            }
            else
            {
                result.Append(c);
            }
        }

        return result.ToString();
    }
}