namespace LeastNumberOfUniqueIntegersAfterKRemovals;

public class Solution 
{
    public int FindLeastNumOfUniqueInts(int[] arr, int k) 
    {
        var freq = new Dictionary<int, int>();
        for (var i = 0; i < arr.Length; i++)
        {
            var num = arr[i];
            freq[num] = freq.GetValueOrDefault(num) + 1;
        }

        var values = freq.Values.ToArray();
        Array.Sort(values);
        for (var i = 0; i < values.Length; i++)
        {
            if (values[i] <= k)
            {
                k -= values[i];
            }
            else
            {
                return values.Length - i;
            }
        }

        return 0;
    }
}