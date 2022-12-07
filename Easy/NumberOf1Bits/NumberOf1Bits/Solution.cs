namespace NumberOf1Bits;

public class Solution {
    public int HammingWeight(uint n) {
        var bits = new List<uint>();
        while (n > 0)
        {
            bits.Add(n % 2);
            n /= 2;
        }

        var count = 0;
        for (int i = bits.Count - 1; i >= 0; i--)
        {
            if (bits[i] > 0)
            {
                count += 1;
            }
        }

        return count;
    }
}