namespace FindLuckyIntegerInArray;

public class Solution {
    public int FindLucky(int[] arr) {
        var freq = new Dictionary<int, int>();
        for (int i = 0; i < arr.Length; i++)
        {
            freq[arr[i]] = freq.GetValueOrDefault(arr[i], 0) + 1;
        }

        int max = -1;
        foreach(var (n, count) in freq)
        {
            if (n == count && n > max)
            {
                max = n;
            }
        }

        return max;
    }
}