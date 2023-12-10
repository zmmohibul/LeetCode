namespace MaximumAverageSubtree;

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

public class Solution {
    double maxAverage = 0;
    public double MaximumAverageSubtree(TreeNode root) {
        ComputeAverage(root, 0);
        return maxAverage;
    }

    public List<int> ComputeAverage(TreeNode node, int count)
    {
        if (node == null)
        {
            return new List<int>{0, 0};
        }

        var leftCalc = ComputeAverage(node.left, 0);
        var rightCalc = ComputeAverage(node.right, 0);

        var sum = leftCalc[0] + rightCalc[0] + node.val;
        count = leftCalc[1] + rightCalc[1] + 1;

        var average = (double) sum / count;
        maxAverage = Math.Max(average, maxAverage);

        return new List<int>{sum, count};
    }
}