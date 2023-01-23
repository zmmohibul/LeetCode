namespace RemoveNodesFromLinkedList;
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
    public ListNode RemoveNodes(ListNode head)
    {
        if (head == null || head.next == null)
        {
            return head;
        }
        
        
        var curr = head;
        var max = head;
        while (curr != null)
        {
            if (curr.val > max.val)
            {
                max = curr;
            }

            curr = curr.next;
        }

        head = max;
        var thead = head;
        curr = head.next;
        while (curr != null)
        {
            var inCur = curr;
            var inMax = curr;
            while (inCur != null)
            {
                if (inCur.val > inMax.val)
                {
                    inMax = inCur;
                }
                inCur = inCur.next;
            }

            if (inMax != curr)
            {
                thead.next = inMax;
                thead = thead.next;
                curr = thead.next;
            }
            else
            {
                thead = thead.next;
                curr = curr.next;
            }
        }

        return head;
    }
    
}