namespace LinkedListCycleII;

public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int x) {
        val = x;
        next = null;
    }
}


public class Solution {
    public ListNode DetectCycle(ListNode head)
    {
        var hs = new HashSet<ListNode>();
        var curr = head;
        while (curr != null && !hs.Contains(curr))
        {
            hs.Add(curr);
            curr = curr.next;
        }

        return curr;
    }
}