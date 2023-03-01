namespace LeftAndRightSumDifferences;

public class Solution
{
    public int[] LeftRigthDifference(int[] nums)
    {
        var leftSum = 0;
        var leftSumArray = new int[nums.Length];
        
        var rightSum = 0;
        var rightSumArray = new int[nums.Length];
        
        int j = nums.Length - 1;
        for (int i = 0; i < nums.Length; i++)
        {
            leftSumArray[i] = leftSum;
            leftSum += nums[i];
            
            rightSumArray[j] = rightSum;
            rightSum += nums[j];
            j--;
        }

        for (int i = 0; i < leftSumArray.Length; i++)
        {
            leftSumArray[i] = Math.Abs(leftSumArray[i] - rightSumArray[i]);
        }

        return leftSumArray;
    }
}