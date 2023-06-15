namespace MaximumLevelSumOfBinaryTree;

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
    public int MaxLevelSum(TreeNode root)
    {
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        var maximalSum = root.val;
        var maximalSumLevel = 1;

        var currLevel = 1;

        while (queue.Count > 0)
        {
            var sum = 0;
            var queueLength = queue.Count;
            for (int i = 0; i < queueLength; i++)
            {
                var node = queue.Dequeue();
                sum += node.val;

                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                }

                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }
            }

            if (sum > maximalSum)
            {
                maximalSum = sum;
                maximalSumLevel = currLevel;
            }

            currLevel++;
        }

        return maximalSumLevel;
    }
}