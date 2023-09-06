namespace SplitLinkedListInParts;

public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}

public class Solution {
    public ListNode[] SplitListToParts(ListNode head, int k) {
        var count = 0;
        var curr = head;
        while (curr != null)
        {
            count++;
            curr = curr.next;
        }

        var result = new ListNode[k];
        var groupSize = count / k;
        var groups = k;
        var rem = count % k;
        if (groupSize == 0)
        {
            groupSize = 1;
            groups = count;
            rem = 0;
        }

        curr = head;
        for (int i = 0; i < groups; i++)
        {
            result[i] = curr;
            for (int j = 0; j < groupSize - 1; j++)
            {
                curr = curr.next;
            }

            if (rem > 0)
            {
                curr = curr.next;
                rem -= 1;
            }

            var temp = curr.next;
            curr.next = null;
            curr = temp;
        }

        return result;
    }
}