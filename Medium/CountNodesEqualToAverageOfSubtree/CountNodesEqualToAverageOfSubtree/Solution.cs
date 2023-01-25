namespace CountNodesEqualToAverageOfSubtree;

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
    public int Result { get; set; } = 0;
    
    public int AverageOfSubtree(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }
        
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while (queue.Count > 0) 
        {
            var node = queue.Dequeue();
            var average = CalculateAverage(node);

            if (average == node.val)
            {
                Result++;
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

        return Result;
    }

    public int CalculateAverage(TreeNode T)
    {
        var queue = new Queue<TreeNode>();
        queue.Enqueue(T);

        int sum = 0;
        int count = 0;
        while (queue.Count > 0)
        {
            var node = queue.Dequeue();
            sum += node.val;
            count++;

            if (node.left != null)
            {
                queue.Enqueue(node.left);
            }

            if (node.right != null)
            {
                queue.Enqueue(node.right);
            }
        }

        return sum / count;
    }
}