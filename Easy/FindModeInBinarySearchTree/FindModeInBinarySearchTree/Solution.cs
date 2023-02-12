namespace FindModeInBinarySearchTree;

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
    public int[] FindMode(TreeNode root)
    {
        if (root == null)
        {
            return new int[0];
        }

        var freq = new Dictionary<int, int>();
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0) {
            var n = queue.Count;
            for (int i = 0; i < n; i++) {
                var node = queue.Dequeue();
                freq[node.val] = freq.GetValueOrDefault(node.val, 0) + 1;

                if (node.left != null) {
                    queue.Enqueue(node.left);
                }

                if (node.right != null) {
                    queue.Enqueue(node.right);
                }
            }
        }

        var maxCount = 0;
        for (int i = 0; i < freq.Count; i++)
        {
            var item = freq.ElementAt(i);
            if (item.Value >= maxCount)
            {
                maxCount = item.Value;
            }
        }

        var list = new List<int>();
        for (int i = 0; i < freq.Count; i++)
        {
            var item = freq.ElementAt(i);
            if (item.Value == maxCount)
            {
                list.Add(item.Key);
            }
        }

        return list.ToArray();
    }
}