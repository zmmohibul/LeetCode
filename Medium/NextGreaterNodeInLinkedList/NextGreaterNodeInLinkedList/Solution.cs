namespace NextGreaterNodeInLinkedList;

public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}

public class Solution {
    public int[] NextLargerNodes(ListNode head) {
        int n = 0;
        var curr = head;
        while (curr != null) 
        {
            n++;
            curr = curr.next;
        }

        var result = new int[n];
        int i = 0;
        curr = head;
        while (curr != null) {
            int great = curr.val;
            var ncurr = curr.next;
            while (ncurr != null) 
            {
                if (ncurr.val > great) 
                {
                    great = ncurr.val;
                    break;
                }
                ncurr = ncurr.next;
            }

            if (great != curr.val)
            {
                result[i] = great;
            }

            i++;
            curr = curr.next;
        }

        return result;
    }
}