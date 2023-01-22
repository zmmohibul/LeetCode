namespace FindLeavesOfBinaryTree;

public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode() {}
    public TreeNode(int val) { this.val = val; }
    public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution
{
    public IList<IList<int>> Result { get; set; } = new List<IList<int>>();
    public IList<IList<int>> FindLeaves(TreeNode root)
    {
        while (root.left != null || root.right != null)
        {
            Result.Add(CollectLeavesOfNode(root));
        }
        
        Result.Add(new List<int>(){root.val});
        return Result;
    }

    public IList<int> CollectLeavesOfNode(TreeNode root)
    {
        var result = new List<int>();
        CollectLeavesOfNode(root, root, result, true);
        return result;
    }

    public void CollectLeavesOfNode(TreeNode parent, TreeNode node, List<int> list, bool left)
    {
        if (node == null)
        {
            return;
        }

        if (node.left == null && node.right == null)
        {
            list.Add(node.val);
            if (left)
            {
                parent.left = null;
            }
            else
            {
                parent.right = null;
            }
            return;
        }

        CollectLeavesOfNode(node, node.left, list, true);
        CollectLeavesOfNode(node, node.right, list, false);
    }
}