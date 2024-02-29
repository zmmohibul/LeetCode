namespace EvenOddTree;

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
    public bool IsEvenOddTree(TreeNode root) {
        var level = 0;
        var queue = new List<TreeNode>();
        queue.Add(root);
        while (queue.Count > 0)
        {
            var prevNodeVal = 0;
            if (level % 2 != 0)
            {
                prevNodeVal = int.MaxValue;
            }

            var currLevelNodes = new List<TreeNode>();

            for (var i = 0; i < queue.Count; i++)
            {
                var currNodeVal = queue[i].val;

                if (level % 2 == 0)
                {
                    if (currNodeVal % 2 == 0 || currNodeVal <= prevNodeVal)
                    {
                        return false;
                    }
                }
                else
                {
                    if (currNodeVal % 2 != 0 || currNodeVal >= prevNodeVal)
                    {
                        return false;
                    }
                }

                if (queue[i].left != null)
                {
                    currLevelNodes.Add(queue[i].left);
                }

                if (queue[i].right != null)
                {
                    currLevelNodes.Add(queue[i].right);
                }

                prevNodeVal = currNodeVal;
            }

            level++;
            queue = currLevelNodes;
        }

        return true;
    }
}