namespace BinaryTreePreorderTraversal;
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
    public IList<int> Result { get; set; } = new List<int>(); 
    public IList<int> PreorderTraversal(TreeNode root)
    {
        PreorderTrav(root);
        return Result;
    }

    public void PreorderTrav(TreeNode T)
    {
        if (T == null)
        {
            return;
        }
        
        Result.Add(T.val);
        PreorderTrav(T.left);
        PreorderTrav(T.right);
    }
}