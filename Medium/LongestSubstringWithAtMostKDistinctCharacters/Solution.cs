namespace LongestSubstringWithAtMostKDistinctCharacters;

public class Solution {
    public int LengthOfLongestSubstringKDistinct(string s, int k) {
        var d = new Dictionary<char, int>();
        int right = 0, left = 0, maxLength = 0;
        while (right < s.Length)
        {
            while (right < s.Length && d.Count <= k)
            {
                d[s[right]] = d.GetValueOrDefault(s[right]) + 1;
                right++;
            }

            var length = right - left;
            if (d.Count > k)
            {
                length--;
            }

            maxLength = Math.Max(length, maxLength);

            while (d.Count > k)
            {
                d[s[left]]--;
                if (d[s[left]] == 0)
                {
                    d.Remove(s[left]);
                }
                left++;
            }
        }
        
        return maxLength;
    }
}