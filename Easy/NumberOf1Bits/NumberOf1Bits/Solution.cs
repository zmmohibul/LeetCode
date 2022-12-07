namespace NumberOf1Bits;

public class Solution {
    public int HammingWeight(uint n)
    {
        var count = 0;
        while (n > 0)
        {
            if (n % 2 == 1)
            {
                count += 1;
            }
            n /= 2;
        }

        return count;
    }
}