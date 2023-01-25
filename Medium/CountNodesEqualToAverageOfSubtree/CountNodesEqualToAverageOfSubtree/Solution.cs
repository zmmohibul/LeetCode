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
    public int Sum { get; set; } = 0;
    public int Count { get; set; } = 0;
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
            CalculateAverage(node);
            var average = Sum / Count;

            if (average == node.val)
            {
                Result++;
            }

            Sum = 0;
            Count = 0;

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

    public void CalculateAverage(TreeNode T)
    {
        if (T == null)
        {
            return;
        }
        
        CalculateAverage(T.left);
        CalculateAverage(T.right);
        
        Sum += T.val;
        Count++;
    }
}