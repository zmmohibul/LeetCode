namespace MiddleOfLinkedList;

public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}

public class Solution {
    public ListNode MiddleNode(ListNode head) {
        int n = 0;
        ListNode curr = head;
        while (curr != null) {
            n += 1;
            curr = curr.next;
        }

        int mid = n / 2;
        curr = head;
        for (int i = 0; i < mid; i++) {
            curr = curr.next;
        }

        return curr;
    }
}