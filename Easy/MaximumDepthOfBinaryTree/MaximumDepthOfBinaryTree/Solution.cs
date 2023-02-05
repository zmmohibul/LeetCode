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

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        int count = 0;
        int n = 1;
        while (queue.Count > 0)
        {
            int inn = 0;
            for (int i = 0; i < n; i++)
            {
                var node = queue.Dequeue();
                
                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                    inn++;
                }

                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                    inn++;
                }
            }

            count++;
            n = inn;
        }

        return count;
    }
}