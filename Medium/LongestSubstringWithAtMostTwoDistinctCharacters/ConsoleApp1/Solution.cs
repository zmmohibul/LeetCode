namespace ConsoleApp1;

public class Solution
{
    public int LengthOfLongestSubstringTwoDistinct(string s) 
    {
        var hs = new HashSet<char>();
        var left = 0;
        var right = 0;
        var longest = 0;
        var dict = new Dictionary<char, int>();

        while (right < s.Length)
        {
            if (hs.Count == 2 && !hs.Contains(s[right]))
            {
                break;
            }
            hs.Add(s[right]);
            dict[s[right]] = right;
            right++;
        }

        var length = right - left;
        longest = length > longest ? length : longest;

        while (right < s.Length)
        {
            while(left < right)
            {
                if (hs.Count == 1)
                {
                    break;
                }

                hs.Remove(s[left]);
                if (dict[s[left]] > left)
                {
                    hs.Add(s[left]);
                }

                left++;
            }

            while (right < s.Length)
            {
                if (hs.Count == 2 && !hs.Contains(s[right]))
                {
                    break;
                }
                hs.Add(s[right]);
                dict[s[right]] = right;
                right++;
            }

            length = right - left;
            longest = length > longest ? length : longest;
        }

        



        return longest;
    }
}