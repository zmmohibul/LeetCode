using System.Text;

namespace LetterCasePermutation;

public class Solution
{
    public IList<string> LetterCasePermutation(string s)
    {
        var sb = new StringBuilder(s);
        var result = new HashSet<string>(){ sb.ToString() };
        for (var i = 0; i < sb.Length; i++)
        {
            var ch = sb[i];
            if (char.IsDigit(ch)) continue;
            
            var subResult = new HashSet<string>();
            foreach (var item in result)
            {
                var itemSb = new StringBuilder(item)
                {
                    [i] = char.ToUpper(ch)
                };
                subResult.Add(itemSb.ToString());

                itemSb[i] = char.ToLower(ch);
                subResult.Add(itemSb.ToString());
            }
                
            result = subResult;
        }
        return result.ToList();
    }
}