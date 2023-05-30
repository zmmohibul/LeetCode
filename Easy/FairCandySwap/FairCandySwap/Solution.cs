namespace FairCandySwap;

public class Solution
{
    public int[] FairCandySwap(int[] aliceSizes, int[] bobSizes)
    {
        var sumAlice = 0;
        for (int i = 0; i < aliceSizes.Length; i++)
        {
            sumAlice += aliceSizes[i];
        }

        var bobSum = 0;
        var hs = new HashSet<int>();
        for (int i = 0; i < bobSizes.Length; i++)
        {
            bobSum += bobSizes[i];
            hs.Add(bobSizes[i]);
        }

        var missing = (bobSum - sumAlice) / 2;
        for (int i = 0; i < aliceSizes.Length; i++)
        {
            var lookingFor = missing + aliceSizes[i];
            if (hs.Contains(lookingFor))
            {
                return new int[] { aliceSizes[i], lookingFor };
            }
        }
        
        return new int[] { 0, 0 };
    }
}