namespace CheckIfStringsCanBeMadeEqualWithOperationsII;

public class Solution {
    public bool CheckStrings(string s1, string s2) 
    {
        return IndicesMatch(0, s1, s2) && IndicesMatch(1, s1, s2);
    }

    public bool IndicesMatch(int start, string s1, string s2)
    {
        var freq = new Dictionary<char, int>();
        for (var i = start; i < s1.Length; i += 2)
        {
            freq[s1[i]] = freq.GetValueOrDefault(s1[i]) + 1;
        }

        for (var i = start; i < s2.Length; i += 2)
        {
            if (!freq.ContainsKey(s2[i]))
            {
                return false;
            }

            freq[s2[i]]--;
            if (freq[s2[i]] == 0)
            {
                freq.Remove(s2[i]);
            }
        }

        return freq.Count == 0;       
    }
}