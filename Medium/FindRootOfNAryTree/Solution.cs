namespace FindRootOfNAryTree;

public class Solution
{
    public Node FindRoot(List<Node> tree)
    {
        var childSum = 0;
        var nodeSum = 0;
        for (int i = 0; i < tree.Count; i++)
        {
            nodeSum += tree[i].val;
            for (int j = 0; j < tree[i].children.Count; j++)
            {
                childSum += tree[i].children[j].val;
            }
        }

        var diff = nodeSum - childSum;
        for (int i = 0; i < tree.Count; i++)
        {
            if (tree[i].val == diff)
            {
                return tree[i];
            }
        }

        return null;
    }
}

public class Node {
    public int val;
    public IList<Node> children;
    
    public Node() {
        val = 0;
        children = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        children = new List<Node>();
    }
    
    public Node(int _val, List<Node> _children) {
        val = _val;
        children = _children;
    }
}
