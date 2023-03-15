using System.Collections;

namespace ReverseOddLevelsOfBinaryTree;

public class TreeNode
{
    public TreeNode left;
    public TreeNode right;
    public int val;

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution
{
    public TreeNode ReverseOddLevels(TreeNode root)
    {
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        int i = 1;
        while (queue.Count > 0)
        {
            var q = new Queue<TreeNode>();
            if (i % 2 == 0)
            {
                while (queue.Count > 0)
                {
                    var n = queue.Dequeue();
                    if (n.left != null)
                    {
                        q.Enqueue(n.left);
                        q.Enqueue(n.right);
                    }
                }
            }
            else
            {
                var list = new List<TreeNode>();
                while (queue.Count > 0)
                {
                    list.Add(queue.Dequeue());
                }

                var m = 0;
                var n = list.Count - 1;
                while (m < n)
                {
                    (list[m].val, list[n].val) = (list[n].val, list[m].val);
                    m++;
                    n--;
                }

                m = 0;
                while (m < list.Count)
                {
                    if (list[m].left != null)
                    {
                        q.Enqueue(list[m].left);
                        q.Enqueue(list[m].right);
                    }

                    m++;
                }
            }

            queue = q;
            i++;
        }

        return root;
    }
}