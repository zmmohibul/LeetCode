namespace CloneNAryTree;


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


public class Solution
{
    public Node CloneTree(Node root)
    {
        var cloneTree = new Node();
        cloneTree.val = root.val;
        
        var queue = new Queue<Node>();
        queue.Enqueue(root);

        var cloneQueue = new Queue<Node>();
        cloneQueue.Enqueue(cloneTree);
        
        while (queue.Count > 0)
        {
            var node = queue.Dequeue();
            var clone = cloneQueue.Dequeue();
            for (int i = 0; i < node.children.Count; i++)
            {
                clone.children.Add(new Node(node.children[i].val));
                queue.Enqueue(node.children[i]);
                cloneQueue.Enqueue(clone.children[i]);
            }
        }

        return cloneTree;
    }
}