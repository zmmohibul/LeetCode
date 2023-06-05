namespace CopyListWithRandomPointer;

public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}


public class Solution {
    public Node CopyRandomList(Node head) {
        if (head == null)
        {
            return null;
        }
        
        var nodeIndex = new  Dictionary<Node, int>();
        var indexToNode = new Dictionary<int, Node>();
        
        var i = 0;
        
        var clone = new Node(head.val);
        var result = clone;
        
        var curr = head;
        while (curr.next != null)
        {
            clone.next = new Node(curr.next.val);

            nodeIndex[curr] = i;
            indexToNode[i] = clone;

            curr = curr.next;
            clone = clone.next;

            i++;
        }
        nodeIndex[curr] = i;
        indexToNode[i] = clone;
        

        curr = head;
        clone = result;
        i = 0;
        while (curr != null)
        {
            if (curr.random != null)
            {
                var ind = nodeIndex[curr.random];
                clone.random = indexToNode[ind];
            }

            indexToNode[i] = clone;
            
            clone = clone.next;
            curr = curr.next;

            i++;
        }

        return result;
    }
}