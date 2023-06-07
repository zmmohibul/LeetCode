namespace FindRootOfNAryTree;

public class Solution
{
    public Node FindRoot(List<Node> tree)
    {
        var children = new Dictionary<int, Node>();

        for (int i = 0; i < tree.Count; i++)
        {
            var node = tree[i];
            for (int j = 0; j < node.children.Count; j++)
            {
                var child = node.children[j];
                children[child.val] = child;
            }
        }

        for (int i = 0; i < tree.Count; i++)
        {
            var node = tree[i];
            if (!children.ContainsKey(node.val))
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
