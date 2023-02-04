namespace MaximumDepthOfBinaryTree;
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
    public int MaxDepth(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }

        int leftTreeDepth = MaxDepth(root.left);
        int rightTreeDepth = MaxDepth(root.right);

        return (leftTreeDepth > rightTreeDepth ? leftTreeDepth : rightTreeDepth) + 1;
    }
}