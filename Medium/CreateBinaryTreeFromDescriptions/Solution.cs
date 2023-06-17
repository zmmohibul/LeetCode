namespace CreateBinaryTreeFromDescriptions;

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
    public TreeNode CreateBinaryTree(int[][] descriptions) 
    {
        var dict = new Dictionary<int, TreeNode>();
        var parents = new HashSet<int>();
        var children = new HashSet<int>();

        foreach (var desc in descriptions)
        {
            parents.Add(desc[0]);
            children.Add(desc[1]);

            if (!dict.ContainsKey(desc[0]))
            {
                dict[desc[0]] = new TreeNode(desc[0]);
            }

            if (!dict.ContainsKey(desc[1]))
            {
                dict[desc[1]] = new TreeNode(desc[1]);
            }

            if (desc[2] == 1)
            {
                dict[desc[0]].left = dict[desc[1]];
            }
            else
            {
                dict[desc[0]].right = dict[desc[1]];
            }
        }

        var parent = parents.Where(p => !children.Contains(p));

        return dict[parent.First()];
        
    }
}