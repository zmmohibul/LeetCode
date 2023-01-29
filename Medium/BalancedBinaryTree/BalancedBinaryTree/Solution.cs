namespace BalancedBinaryTree;

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
    public bool IsBalanced(TreeNode root)
    {
        if (root == null)
        {
            return true;
        }

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            var node = queue.Dequeue();

            if (Math.Abs(FindDepth(node.left) - FindDepth(node.right)) > 1)
            {
                return false;
            }

            if (node.left != null)
            {
                queue.Enqueue(node.left);
            }

            if (node.right != null)
            {
                queue.Enqueue(node.right);
            }
        }

        return true;
    }

    public int FindDepth(TreeNode T)
    {
        if (T == null)
        {
            return 0;
        }

        int left = FindDepth(T.left);
        int right = FindDepth(T.right);

        return Math.Max(left, right) + 1;
    }
}