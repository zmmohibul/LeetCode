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

public class Solution {
    public bool Found { get; set; } = false;
    public bool FindTarget(TreeNode root, int k) {
        var hs = new HashSet<int>();
        Find(root, k, hs);
        return Found;
        
    }

    public void Find(TreeNode root, int k, HashSet<int> hs)
    {
        if (root == null)
        {
            return;
        }

        if (hs.Contains(k - root.val))
        {
            Found = true;
            return;
        }
        
        hs.Add(root.val);
        Find(root.left, k, hs);
        Find(root.right, k, hs);
    }
}