namespace JewelsAndStones;

public class Solution
{
    public int NumJewelsInStones(string jewels, string stones)
    {
        var hsJewels = new HashSet<char>();
        for (int i = 0; i < jewels.Length; i++)
        {
            hsJewels.Add(jewels[i]);
        }

        var count = 0;
        for (int i = 0; i < stones.Length; i++)
        {
            if (hsJewels.Contains(stones[i]))
            {
                count++;
            }
        }

        return count;
    }
}