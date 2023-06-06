namespace FindThePrefixCommonArrayOfTwoArrays;

public class Solution 
{
    public int[] FindThePrefixCommonArray(int[] A, int[] B) 
    {
        var hsA = new HashSet<int>();
        var hsB = new HashSet<int>();
        var result = new int[A.Length];
        for (int i = 0; i < A.Length; i++)
        {
            hsA.Add(A[i]);
            hsB.Add(B[i]);
            var count = 0;
            foreach (var it in hsB)
            {
                if (hsA.Contains(it))
                {
                    count++;
                }
            }
            result[i] = count;
        }

        return result;
    }
}