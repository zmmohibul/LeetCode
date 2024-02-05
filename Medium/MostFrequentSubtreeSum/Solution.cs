namespace MostFrequentSubtreeSum;

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
    Dictionary<int, int> sumFreq = new();
    public int[] FindFrequentTreeSum(TreeNode root) {
        TreeSum(root);
        
        var maxCount = sumFreq.Values.Max();
        var result = new List<int>();
        foreach (var (sum, count) in sumFreq)
        {
            if (count == maxCount)
            {
                result.Add(sum);
            }
        }

        return result.ToArray();
    }

    private int TreeSum(TreeNode node)
    {
        if (node == null)
        {
            return 0;
        }

        var leftSum = TreeSum(node.left);
        var rightSum = TreeSum(node.right);

        var sum = node.val + leftSum + rightSum;
        sumFreq[sum] = sumFreq.GetValueOrDefault(sum) + 1;

        return sum;
    }
}