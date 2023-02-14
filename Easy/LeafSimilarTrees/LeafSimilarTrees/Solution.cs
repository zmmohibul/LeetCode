namespace LeafSimilarTrees;

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
    public List<int> LeavesRoot1 { get; set; } = new List<int>();
    public List<int> LeavesRoot2 { get; set; } = new List<int>();
    
    public bool LeafSimilar(TreeNode root1, TreeNode root2)
    {
        GetLeafNodes(root1, LeavesRoot1);
        GetLeafNodes(root2, LeavesRoot2);

        if (LeavesRoot1.Count != LeavesRoot2.Count)
        {
            return false;
        }

        for (int i = 0; i < LeavesRoot1.Count; i++)
        {
            if (LeavesRoot1[i] != LeavesRoot2[i])
            {
                return false;
            }
        }

        return true;
    }
    
    public void GetLeafNodes(TreeNode root, List<int> list)
    {
        if (root == null)
        {
            return;
        }

        if (root.left == null && root.right == null)
        {
            list.Add(root.val);
        }
        
        GetLeafNodes(root.left, list);
        GetLeafNodes(root.right, list);
    }
}