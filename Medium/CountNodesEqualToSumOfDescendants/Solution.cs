namespace CountNodesEqualToSumOfDescendants;

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
    int count = 0;
    public int EqualToDescendants(TreeNode root) {
        ComputeSum(root);
        return count;
    }

    public int ComputeSum(TreeNode node)
    {
        if (node == null)
        {
            return 0;
        }

        var leftSum = ComputeSum(node.left);
        var rightSum = ComputeSum(node.right);
        var total = leftSum + rightSum;

        if (total == node.val)
        {
            count++;
        }

        return total + node.val;
    }
}