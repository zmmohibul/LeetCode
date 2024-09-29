namespace LengthOfLongestFibonacciSubsequence;

public class Solution {
    public int LenLongestFibSubseq(int[] arr) {
        var set = new HashSet<int>(arr);
        var length = 0;
        for (var i = 0; i < arr.Length; i++)
        {
            for (var j = i + 1; j < arr.Length; j++)
            {
                var n1 = arr[i];
                var n2 = arr[j];
                var currLength = 0;
                while (set.Contains(n1 + n2))
                {
                    (n1, n2) = (n2, n1 + n2);
                    currLength++;
                }

                length = Math.Max(currLength, length);
            }
        }
        return length > 0 ? length + 2 : length;
    }
}