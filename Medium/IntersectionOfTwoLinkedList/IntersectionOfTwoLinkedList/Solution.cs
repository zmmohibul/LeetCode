namespace IntersectionOfTwoLinkedList;

public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int x) { val = x; }
}

public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        var hs = new HashSet<ListNode>();
        var h1 = headA;
        while(h1 != null)
        {
            hs.Add(h1);
            h1 = h1.next;
        }

        var h2 = headB;
        while(h2 != null)
        {
            if (hs.Contains(h2))
            {
                return h2;
            }

            h2 = h2.next;
        }

        return null;
    }
}