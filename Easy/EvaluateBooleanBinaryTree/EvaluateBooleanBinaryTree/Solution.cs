namespace EvaluateBooleanBinaryTree;
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
    public bool EvaluateTree(TreeNode root)
    {
        if (root.val == 0 || root.val == 1) 
        {
            return root.val == 0 ? false : true;
        }
        else
        {
            var left = EvaluateTree(root.left);
            var right = EvaluateTree(root.right);
            
            var result = left || right;
            if (root.val == 3)
            {
                result = left && right;
            }
            
            root.val = result == false ? 0 : 1;
            return result;
        }
    }
}