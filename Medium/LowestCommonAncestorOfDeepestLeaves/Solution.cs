namespace LowestCommonAncestorOfDeepestLeaves;

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
    private Dictionary<int, TreeNode> NodeMap = new Dictionary<int, TreeNode>();
    private Dictionary<int, int> NodeParent = new Dictionary<int, int>();
    private HashSet<int> DeepestNodeValues = new HashSet<int>();
    private int MaxHeight = 0;
    
    public TreeNode LcaDeepestLeaves(TreeNode root) 
    {
        FindDeepestNodes(root, root, 1);

        if (DeepestNodeValues.Count == 1)
        {
            return NodeMap[DeepestNodeValues.First()];
        }

        while (true)
        {
            var temp = new HashSet<int>();
            foreach (var nodeValue in DeepestNodeValues)
            {
                temp.Add(NodeParent[nodeValue]);
            }

            if (temp.Count == 1)
            {
                return NodeMap[temp.First()];
            }

            DeepestNodeValues = temp;
        }
    }

    public void FindDeepestNodes(TreeNode node, TreeNode parent, int currHeight)
    {
        if (node == null) return;

        if (currHeight > MaxHeight)
        {
            MaxHeight = currHeight;
            DeepestNodeValues = new HashSet<int>();
        }

        if (currHeight == MaxHeight)
        {
            DeepestNodeValues.Add(node.val);
        }

        NodeMap[node.val] = node;
        NodeParent[node.val] = parent.val;

        FindDeepestNodes(node.left, node, currHeight + 1);
        FindDeepestNodes(node.right, node, currHeight + 1);
    }
}