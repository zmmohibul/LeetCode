namespace CousinsInBinaryTreeII;

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
    public TreeNode ReplaceValueInTree(TreeNode root) 
    {
        var list = new List<TreeNode>();
        list.Add(root);

        while (list.Count > 0)
        {
            var temp = new List<TreeNode>();

            var sum = 0;
            for (int j = 0; j < list.Count; j++)
            {
                var cousinNodeParent = list[j];
                if (cousinNodeParent.left != null)
                {
                    sum += cousinNodeParent.left.val;
                }

                if (cousinNodeParent.right != null)
                {
                    sum += cousinNodeParent.right.val;
                }
            }

            for (int i = 0; i < list.Count; i++)
            {
                var node = list[i];
                
                var nSum = sum;
                if (node.left != null) nSum -= node.left.val;
                if (node.right != null) nSum -= node.right.val;
                

                if (node.left != null)
                {
                    node.left.val = nSum;
                    temp.Add(node.left);
                }

                if (node.right != null)
                {
                    node.right.val = nSum;
                    temp.Add(node.right);
                }
            }

            list = temp;
        }
        
        root.val = 0;
        return root;
    }
}