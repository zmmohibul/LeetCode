namespace SumOfAllOddLengthSubarrays;

public class Solution
{
    public int SumOddLengthSubarrays(int[] arr)
    {
        var totalSum = 0;
        for (int i = 1; i <= arr.Length; i += 2)
        {
            var sum = 0;
            for (int j = 0; j < i; j++)
            {
                sum += arr[j];
            }
            totalSum += sum;

            var k = 0;
            for (int j = i; j < arr.Length; j++)
            {
                sum -= arr[k];
                k++;
                sum += arr[j];
                totalSum += sum;
            }
        }

        return totalSum;
    }
}