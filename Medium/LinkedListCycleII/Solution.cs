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
    public ListNode DetectCycle(ListNode head) {
        var curr = head;
        while (true)
        {
            var nd = DetectCycleInside(curr);

            if (nd == curr || nd == null)
            {
                return nd;
            }

            curr = curr.next;
        }
    }

    public ListNode DetectCycleInside(ListNode curr) {
        var fast = curr;
        var slow = curr;
        while (true)
        {
            if (slow == null || fast.next == null)
            {
                return null;
            }
            else {
                slow = slow.next;
                if (slow == curr)
                {
                    return slow;
                }
                
                fast = fast.next;
                if (fast == curr)
                {
                    return fast;
                }

                if (fast.next == null)
                {
                    return null;
                }

                fast = fast.next;
                if (fast == curr)
                {
                    return fast;
                }
            }

            if (fast == slow)
            {
                return fast;
            }
        }
    }
}