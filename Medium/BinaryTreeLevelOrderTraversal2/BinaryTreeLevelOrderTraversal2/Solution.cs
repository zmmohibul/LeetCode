namespace BinaryTreeLevelOrderTraversal2;

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
    public IList<IList<int>> LevelOrderBottom(TreeNode root)
    {
        var result = new List<IList<int>>();
        if (root == null)
        {
            return result;
        }

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        int n = 1;
        while (queue.Count > 0)
        {
            var subRes = new List<int>();
            int nextLevelCount = 0;
            for (int i = 0; i < n; i++)
            {
                var node = queue.Dequeue();
                subRes.Add(node.val);
                
                if (node.left != null)
                {
                    nextLevelCount++;
                    queue.Enqueue(node.left);
                }

                if (node.right != null)
                {
                    nextLevelCount++;
                    queue.Enqueue(node.right);
                }
            }

            result.Add(subRes);
            n = nextLevelCount;
        }

        result.Reverse();
        return result;
    }
}