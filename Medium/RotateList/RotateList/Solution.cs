namespace RotateList;

public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}

public class Solution {
    public ListNode RotateRight(ListNode head, int k)
    {
        if (k == 0 || head == null || head.next == null)
        {
            return head;
        }
        
        int length = 0;
        var curr = head;
        var tail = new ListNode();
        var tempHead = head;
        
        while (curr != null)
        {
            if (curr.next == null)
            {
                tail = curr;
            }
            length += 1;
            curr = curr.next;
        }
        

        curr = head;
        var n = 0;
        
        if (k == length)
        {
            return head;
        }
        
        if (k > length)
        {
            k /= length;
            n = length - k;
        }
        else
        {
            n = length - k;
        }
        
        for (int i = 0; i < n - 1; i++)
        {
            curr = curr.next;
        }

        tempHead = curr.next;
        curr.next = null;
        tail.next = head;

        head = tempHead;
        
        
        

        return head;
    }
}