namespace KthLargestSumInBinaryTree;

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
    public long KthLargestLevelSum(TreeNode root, int k)
    {
        var pq = new PriorityQueue<long, long>(new LongMaxComparer());

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            var qLen = queue.Count;
            long sum = 0;
            for (int i = 0; i < qLen; i++)
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
            
            pq.Enqueue(sum, sum);
        }

        k -= 1;
        for (int i = 0; i < k; i++)
        {
            pq.Dequeue();
        }

        return pq.Dequeue();



    }
    
}

public class LongMaxComparer : IComparer<long>
{
    public int Compare(long x, long y) => y.CompareTo(x);
}