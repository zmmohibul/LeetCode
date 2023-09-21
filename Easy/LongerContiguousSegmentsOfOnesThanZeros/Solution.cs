namespace LongerContiguousSegmentsOfOnesThanZeros;

public class Solution {
    public bool CheckZeroOnes(string s) {
        var maxOnes = 0;
        var maxZeros = 0;
        var i = 0;
        while (i < s.Length)
        {
            var c = s[i];
            var count = 0;
            while (i < s.Length && s[i] == c)
            {
                count++;
                i++;
            }

            if (c == '0')
            {
                maxZeros = Math.Max(maxZeros, count);
            }
            else
            {
                maxOnes = Math.Max(maxOnes, count);
            }
        }
        
        return maxOnes > maxZeros;
    }
}