namespace RemoveNodeFromLinkedList;
public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}

public class Solution {
    public ListNode RemoveNodes(ListNode head)
    {
        if (head == null || head.next == null)
        {
            return head;
        }
        
        var sentinal = new ListNode(0, head);
        var scur = sentinal;
        while (scur.next != null)
        {
            var curr = scur.next;
            var cval = curr.val;
            var del = false;
            while (curr != null)
            {
                if (curr.val > cval)
                {
                    del = true;
                    break;
                }
                curr = curr.next;
            }

            if (del)
            {
                scur.next = scur.next.next;
            }
            else
            {
                scur = scur.next;
            }
        }

        return sentinal.next;
    }
}