namespace RearrangeArrayElementsBySign;

public class Solution
{
    public int[] RearrangeArray(int[] nums)
    {
        var positives = new int[nums.Length];
        int i = 0;

        var negatives = new int[nums.Length];
        int j = 0;
        
        foreach (var num in nums)
        {
            if (num > 0)
            {
                positives[i] = num;
                i++;
            }
            else
            {
                negatives[j] = num;
                j++;
            }
        }

        i = 0;
        int k = 0;
        while (k < nums.Length)
        {
            nums[k] = positives[i];
            k++;
            nums[k] = negatives[i];
            k++;
            i++;
        }

        return nums;
    }
}