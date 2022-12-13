namespace FindDistanceValueBetweenTwoArrays;

public class Solution {
    public int FindTheDistanceValue(int[] arr1, int[] arr2, int d) {
        var hs = new HashSet<int>();
        for (int i = 0; i < arr2.Length; i++)
        {
            hs.Add(arr2[i]);
        }

        var count = 0;
        for (int i = 0; i < arr1.Length; i++)
        {
            var n = arr1[i];
            var y = true;
            for (int j = 0; j <= d; j++)
            {
                if (hs.Contains(n))
                {
                    y = false;
                    break;
                }
                n -= 1;
            }

            if (!y)
            {
                continue;
            }
            
            n = arr1[i];
            for (int j = 0; j <= d; j++)
            {
                if (hs.Contains(n))
                {
                    y = false;
                    break;
                }
                n += 1;
            }

            if (y)
            {
                count += 1;
            }
        }
        
        return count;
    }
}