namespace SumRootToLeafNumbers;

public class TreeNode
{
    public TreeNode left;
    public TreeNode right;
    public int val;

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution
{
    public int Sum { get; set; }

    public int SumNumbers(TreeNode root)
    {
        SumNumbers(root, 0);
        return Sum;
    }

    public void SumNumbers(TreeNode root, int n)
    {
        if (root == null) return;

        n *= 10;
        n += root.val;


        SumNumbers(root.left, n);
        SumNumbers(root.right, n);

        if (root.left == null && root.right == null) Sum += n;
        n /= 10;
    }
}