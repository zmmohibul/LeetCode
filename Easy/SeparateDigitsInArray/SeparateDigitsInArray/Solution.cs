namespace SeparateDigitsInArray;

public class Solution 
{
    public int[] SeparateDigits(int[] nums) 
    {
        var result = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            var n = nums[i];
            var subRes = new List<int>();
            while (n > 0) 
            {
                subRes.Add(n % 10);
                n /= 10;
            }

            for (int j = subRes.Count - 1; j >= 0; j--)
            {
                result.Add(subRes[j]);
            }
        }

        return result.ToArray();
    }
}