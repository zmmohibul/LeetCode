namespace UnivaluedBinaryTree;

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
    public bool IsUnivalTree(TreeNode root)
    {
        var rootVal = root.val;
        return IsUnivalTree(root, rootVal);
    }

    public bool IsUnivalTree(TreeNode root, int rootVal)
    {
        if (root == null)
        {
            return true;
        }

        if (root.val != rootVal)
        {
            return false;
        }
        
        var left = IsUnivalTree(root.left, rootVal);
        var right = IsUnivalTree(root.right, rootVal);

        return left && right;
    }
}