namespace FindPivotInteger;

public class Solution
{
    public static int PivotInteger(int n)
    {
        // 8
        // 1 2 3 4 5 6 7 8
        // {1: 1, 3: 2, 6: 3, 10: 4, 15: 5, 21: 6}
        int sum = 0;
        var d = new Dictionary<int, int>();
        for (int i = 1; i <= n; i++)
        {
            sum += i;
            d[sum] = i;
        }

        sum = 0;
        for (int i = n; i > 0; i--)
        {
            sum += i;
            if (d.ContainsKey(sum) && d[sum] == i)
            {
                return d[sum];
            }
        }

        return -1;

    }
}