namespace SwapNodesInPairs;

public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public ListNode SwapPairs(ListNode head)
    {
        if (head == null || head.next == null)
        {
            return head;
        }
        
        var sentinel = new ListNode(-1, head);
        var curr = head;
        var prev = sentinel;
        var next = curr.next;
        while (next != null)
        {
            curr.next = next.next;
            next.next = curr;
            prev.next = next;


            prev = curr;
            curr = curr.next;
            if (curr == null)
            {
                break;
            }
            next = curr.next;
        }

        return sentinel.next;
    }
}