namespace MaximumDifferenceBetweenNodeAndAncestor;

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
    int vMax = 0;
    public int MaxAncestorDiff(TreeNode root) {
        var queue = new List<TreeNode>(){root};
        while (queue.Count > 0)
        {
            var newQueue = new List<TreeNode>();
            foreach (var node in queue)
            {
                ComputeAncestorDiff(node, node.val);

                if (node.left != null)
                {
                    newQueue.Add(node.left);
                }

                if (node.right != null)
                {
                    newQueue.Add(node.right);
                }
            }

            queue = newQueue;
        }
        
        return vMax;
    }

    public void ComputeAncestorDiff(TreeNode node, int nval)
    {
        if (node == null)
        {
            return;
        }

        var diff = Math.Abs(nval - node.val);
        if (diff > vMax)
        {
            vMax = diff;
        }

        ComputeAncestorDiff(node.left, nval);
        ComputeAncestorDiff(node.right, nval);
    }
}