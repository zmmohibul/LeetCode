namespace TwoSumIVInputIsBST;

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
    public bool FindTarget(TreeNode root, int k) 
    {
        var hs = new HashSet<int>();
        return Find(root, k, hs);
        
    }

    public bool Find(TreeNode root, int k, HashSet<int> hs)
    {
        if (root == null)
        {
            return false;
        }

        if (hs.Contains(k - root.val))
        {
            return true;
        }
        
        hs.Add(root.val);
        return Find(root.left, k, hs) || Find(root.right, k, hs);
    }
}