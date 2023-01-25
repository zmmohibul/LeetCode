namespace CountNodesEqualToAverageOfSubtree;

public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution
{
    public int Sum { get; set; } = 0;
    public int Count { get; set; } = 0;
    public int Result { get; set; } = 0;

    public int AverageOfSubtree(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }

        CalculateAverage(root);
        return Result;


    }

    public int[] CalculateAverage(TreeNode T)
    {
        if (T == null)
        {
            return new int[] { 0, 0 };
        }

        var sumCountLeft = CalculateAverage(T.left);
        Sum = 0;
        Count = 0;
        
        var sumCountRight = CalculateAverage(T.right);
        Sum = 0;
        Count = 0;

        var totalSum = sumCountLeft[0] + sumCountRight[0] + T.val;
        var totalCount = sumCountLeft[1] + sumCountRight[1] + 1;
        
        var average = totalSum / totalCount;
        if (T.val == average)
        {
            Result++;
        }

        return new[] { totalSum, totalCount };
    }
}