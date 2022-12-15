namespace TwoFurthestHousesWithDifferentColors;

public class Solution
{
    public int MaxDistance(int[] colors)
    {
        int max = 0;
        for (int i = 0; i < colors.Length; i++)
        {
            for (int j = i + 1; j < colors.Length; j++)
            {
                if (colors[i] != colors[j])
                {
                    max = Math.Max(max, Math.Abs(i - j));
                }
            }
        }

        return max;
    }
}
