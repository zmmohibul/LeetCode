using System.Text;

namespace SortVowelsInString;

public class Solution 
{
    public string SortVowels(string s) 
    {
        var vowels = new HashSet<char>{ 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        var arr = new int[125];
        foreach (var c in s)
        {
            if (vowels.Contains(c))
            {
                arr[c] += 1;
            }
        }
        
        var result = new StringBuilder();
        foreach (var c in s)
        {
            if (vowels.Contains(c))
            {
                var i = 0;
                while (arr[i] == 0)
                {
                    i++;
                }
                
                result.Append(Convert.ToChar(i));
                arr[i] -= 1;
            }
            else
            {
                result.Append(c);
            }
        }

        return result.ToString();
    }
}

