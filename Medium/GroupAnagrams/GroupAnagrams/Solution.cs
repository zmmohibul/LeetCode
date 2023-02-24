namespace GroupAnagrams;

public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var result = new List<IList<string>>();
        var groups = new Dictionary<string, IList<string>>();

        for (int i = 0; i < strs.Length; i++)
        {
            var str = strs[i];
            var chars = str.ToCharArray();
            Array.Sort(chars);
            var newstr = String.Concat(chars);
            if (!groups.ContainsKey(newstr))
            {
                groups[newstr] = new List<string>();
            }
            groups[newstr].Add(str);
        }

        for (int i = 0; i < groups.Count; i++)
        {
            result.Add(groups.ElementAt(i).Value);
        }
        
        return result;
    }
}