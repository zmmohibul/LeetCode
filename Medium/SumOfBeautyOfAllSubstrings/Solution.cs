namespace SumOfBeautyOfAllSubstrings;

public class Solution 
{
    public int BeautySum(string s) 
    {
        var freq = new Dictionary<char, int>();
        var sum = 0;
        for (int i = 0; i < s.Length; i++)
        {
            for (int j = i; j < s.Length; j++)
            {
                freq[s[j]] = freq.GetValueOrDefault(s[j], 0) + 1;
                if (freq.Count > 1)
                {
                    sum += (freq.Values.Max() - freq.Values.Min());
                }
            }

            freq = new Dictionary<char, int>();
        }

        return sum;
    }
}