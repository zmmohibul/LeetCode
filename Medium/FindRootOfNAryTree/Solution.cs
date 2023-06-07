namespace FindRootOfNAryTree;

public class Solution
{
    public Node FindRoot(List<Node> tree)
    {
        var children = new Dictionary<int, Node>();
        var nodes = new Dictionary<int, Node>();

        foreach (var node in tree)
        {
            nodes[node.val] = node;

            foreach (var child in node.children)
            {
                nodes[child.val] = child;
                children[child.val] = child;
            }
        }

        foreach (var (val, node) in nodes)
        {
            if (!children.ContainsKey(val))
            {
                return node;
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
