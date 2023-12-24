namespace MinimumChangesToMakeAlternatingBinaryString;

public class Solution {
    public int MinOperations(string s) {
        var count = 0;
        var count2 = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (i % 2 == 0)
            {
                if (s[i] != '0') 
                {
                    count++;
                }

                if (s[i] != '1')
                {
                    count2++;
                }
            }
            else
            {
                if (s[i] != '1')
                {
                    count++;
                }

                if (s[i] != '0')
                {
                    count2++;
                }
            }
        }

        return count < count2 ? count : count2;
    }
}