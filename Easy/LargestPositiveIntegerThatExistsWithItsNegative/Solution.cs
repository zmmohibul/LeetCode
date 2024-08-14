namespace LargestPositiveIntegerThatExistsWithItsNegative;

public class Solution
{
    public int FindMaxK(int[] nums)
    {
        var negatives = nums.Where(n => n < 0).ToHashSet();
        var positivesWithItsNegative = nums
            .Where(n => n > 0 && negatives.Contains(n * -1));

        return positivesWithItsNegative.Any() ? positivesWithItsNegative.Max() : -1;
    }
}