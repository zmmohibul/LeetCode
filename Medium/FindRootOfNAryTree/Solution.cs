namespace FindRootOfNAryTree;

public class Solution
{
    public Node FindRoot(List<Node> tree)
    {
        var node = tree[0];
        var parent = node;
        while (true)
        {
            parent = FindParent(node, tree);
            if (parent == null)
            {
                return node;
            }
            else
            {
                node = parent;
            }
        }

        
    }

    public Node FindParent(Node n, List<Node> tree)
    {
        for (int i = 0; i < tree.Count; i++)
        {
            var node = tree[i];
            for (int j = 0; j < node.children.Count; j++)
            {
                var child = node.children[j];
                if (child.val == n.val)
                {
                    return node;
                }
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
