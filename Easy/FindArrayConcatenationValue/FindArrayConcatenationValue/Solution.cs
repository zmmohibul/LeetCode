namespace FindArrayConcatenationValue;

public class Solution
{
    public long FindTheArrayConcVal(int[] nums)
    {
        int i = 0;
        int j = nums.Length - 1;

        long result = 0;

        while (i < j)
        {
            var first = nums[i];
            var last = nums[j];
            var lastSplit = new List<int>();
            while (last > 0)
            {
                lastSplit.Add(last % 10);
                last /= 10;
            }

            for (int k = lastSplit.Count - 1; k > -1; k--)
            {
                first *= 10;
                first += lastSplit[k];
            }

            result += first;
            
            i++;
            j--;
        }

        if (i == j)
        {
            result += nums[i];
        }

        return result;
    }
}