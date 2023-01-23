namespace PopulatingNextRightPointersInEachNode;
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next) {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
}

public class Solution
{
    public Node Connect(Node root)
    {
        if (root == null || root.left == null)
        {
            return root;
        }
        
        var queue = new Queue<Node>();
        queue.Enqueue(root.left);
        queue.Enqueue(root.right);
        
        while (queue.Count > 0)
        {
            var newQueue = new Queue<Node>();
            var last = queue.Dequeue();
            while (queue.Count > 0)
            {
                var n = queue.Dequeue();
                last.next = n;
                if (last.left != null)
                {
                    newQueue.Enqueue(last.left);
                    newQueue.Enqueue(last.right);
                }
                last = n;
            }

            if (last.left != null)
            {
                newQueue.Enqueue(last.left);
                newQueue.Enqueue(last.right);
            }

            queue = newQueue;
        }

        return root;
    }
}