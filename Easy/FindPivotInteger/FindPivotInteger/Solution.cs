namespace FindPivotInteger;

public class Solution
{
    public static int PivotInteger(int n)
    {
        int leftSum = 1;
        int rightSum = n;

        int left = 1;
        int right = n;
        while (left <= right)
        {
            if ((leftSum == rightSum) && (left == right))
            {
                return left;
            }

            if (leftSum < rightSum)
            {
                left += 1;
                leftSum += left;
            }
            else
            {
                right -= 1;
                rightSum += right;
            }
        }

        return -1;
    }
}