namespace AllElementsInTwoBinarySearchTrees;
using System;
using System.Collections.Generic;

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
    public List<int> Result1 { get; set; } = new List<int>();
    public List<int> Result2 { get; set; } = new List<int>();
    public IList<int> GetAllElements(TreeNode root1, TreeNode root2)
    {
        GetAllElements(root1, this.Result1);
        GetAllElements(root2, this.Result2);

        var res = new List<int>();
        var i = 0;
        var j = 0;
        while (i < Result1.Count && j < Result2.Count)
        {
            if (Result1[i] < Result2[j])
            {
                res.Add(Result1[i]);
                i++;
            }
            else
            {
                res.Add(Result2[j]);
                j++;
            }
        }

        if (i < Result1.Count)
        {
            while (i < Result1.Count)
            {
                res.Add(Result1[i]);
                i++;
            }
        }

        if (j < Result2.Count)
        {
            while (j < Result2.Count)
            {
                res.Add(Result2[j]);
                j++;
            }
        }

        return res;
    }

    public void GetAllElements(TreeNode T, List<int> Result)
    {
        if (T == null)
        {
            return;
        }

        GetAllElements(T.left, Result);
        Result.Add(T.val);
        GetAllElements(T.right, Result);
    }
}