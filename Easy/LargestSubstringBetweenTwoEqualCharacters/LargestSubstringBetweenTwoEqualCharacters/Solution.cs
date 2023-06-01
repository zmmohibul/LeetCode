namespace LargestSubstringBetweenTwoEqualCharacters;

public class Solution
{
    public int MaxLengthBetweenEqualCharacters(string s)
    {
        var longestLength = -1;
        var charIndices = new Dictionary<char, List<int>>();
        for (int i = 0; i < s.Length; i++)
        {
            if (!charIndices.ContainsKey(s[i]))
            {
                charIndices[s[i]] = new List<int>();
            }

            if (charIndices[s[i]].Count == 2)
            {
                charIndices[s[i]][1] = i;
            }
            else
            {
                charIndices[s[i]].Add(i);
            }
        }

        foreach (var indices in charIndices.Values)
        {
            if (indices.Count == 2)
            {
                var length = indices[1] - indices[0] + 1 - 2;
                longestLength = Math.Max(length, longestLength);
            }
        }

        return longestLength;
    }
}