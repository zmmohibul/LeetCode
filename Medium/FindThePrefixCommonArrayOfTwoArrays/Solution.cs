namespace FindThePrefixCommonArrayOfTwoArrays;

public class Solution 
{
    public int[] FindThePrefixCommonArray(int[] A, int[] B) 
    {
        var hsA = new HashSet<int>();
        var hsB = new HashSet<int>();

        var count = 0;
        var result = new int[A.Length];

        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] == B[i])
            {
                count++;
            }
            else 
            {
                hsA.Add(A[i]);
                hsB.Add(B[i]);

                if (hsA.Contains(B[i]))
                {
                    count++;
                }

                if (hsB.Contains(A[i]))
                {
                    count++;
                }
            }

            result[i] = count;
        }

        return result;
    }
}