namespace MergeKSortedList;


public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}

public class Solution {
    public ListNode MergeKLists(ListNode[] lists) {
        var sentinal = new ListNode(0, null);
        var curr = sentinal;
        var pq = new PriorityQueue<ListNode, int>();
        for (int i = 0; i < lists.Length; i++)
        {
            var cl = lists[i];
            pq.Enqueue(cl, cl.val);
        }

        while (pq.Count > 0)
        {
            var v = pq.Dequeue();
            curr.next = new ListNode(v.val, null);
            curr = curr.next;
            v = v.next;
            if (v != null)
            {
                pq.Enqueue(v, v.val);
            }
        }
        
        return sentinal.next;
    }
}