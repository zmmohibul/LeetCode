namespace IncreasingOrderSearchTree;

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
    TreeNode result = new TreeNode();
    public TreeNode IncreasingBST(TreeNode root) {
        var p = result;
        Traverse(root);
        return p.right;
    }

    public void Traverse(TreeNode node)
    {
        if (node == null)
        {
            return;
        }

        Traverse(node.left);
        result.right = new TreeNode(node.val);
        result = result.right;
        Traverse(node.right);
    }
}