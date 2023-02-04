namespace PartitionList;
public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public ListNode Partition(ListNode head, int x)
    {
        var sentinel = new ListNode(-101);
        var sentinelCurr = sentinel;
        var curr = head;
        while (curr != null)
        {
            if (curr.val < x)
            {
                sentinelCurr.next = new ListNode(curr.val);
                sentinelCurr = sentinelCurr.next;
            }
            curr = curr.next;
        }

        curr = head;
        while (curr != null)
        {
            if (curr.val >= x)
            {
                sentinelCurr.next = new ListNode(curr.val);
                sentinelCurr = sentinelCurr.next;
            }
            curr = curr.next;
        }

        return sentinel.next;
    }
}