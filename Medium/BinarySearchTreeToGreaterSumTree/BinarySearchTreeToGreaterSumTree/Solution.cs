namespace BinarySearchTreeToGreaterSumTree;

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
    public HashSet<int> NodesSeen { get; set; }
    public int CurrSum { get; set; }

    public Solution()
    {
        NodesSeen = new HashSet<int>();
        CurrSum = 0;
    }

    public TreeNode BstToGst(TreeNode root)
    {
        BstToGstRec(root);
        return root;
    }

    public void BstToGstRec(TreeNode root)
    {
        if (root == null)
        {
            return;
        }
        
        BstToGstRec(root.right);

        if (!NodesSeen.Contains(root.val))
        {
            CurrSum += root.val;
            root.val = CurrSum;
            NodesSeen.Add(CurrSum);
        }
        
        BstToGstRec(root.left);
    }
}