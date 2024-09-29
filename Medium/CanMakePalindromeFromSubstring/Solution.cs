public class Solution
{
    public IList<bool> CanMakePaliQueries(string s, int[][] queries)
    {
        var result = new List<bool>();
        var prefixMap = new Dictionary<int, Dictionary<char, int>>(){{-1, new()}};
        for (var i = 0; i < s.Length; i++)
        {
            var map = new Dictionary<char, int>(prefixMap[i - 1]);
            map[s[i]] = map.GetValueOrDefault(s[i]) + 1;
            prefixMap[i] = map;
        }

        foreach (var query in queries)
        {
            var leftPrefixMap = prefixMap[query[0] - 1];
            var rightPrefixMap = new Dictionary<char, int>(prefixMap[query[1]]);
            foreach (var (c, v) in leftPrefixMap)
            {
                rightPrefixMap[c] -= v;
            }

            var oddCount = 0;
            foreach (var (c, v) in rightPrefixMap)
            {
                if (v % 2 != 0) oddCount++;
            }

            oddCount -= (query[2] * 2);
            result.Add(oddCount <= 1);
        }

        return result;
    }
}