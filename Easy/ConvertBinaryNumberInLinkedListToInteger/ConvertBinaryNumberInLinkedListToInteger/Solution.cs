namespace ConvertBinaryNumberInLinkedListToInteger;

public class ListNode 
{
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
    public int GetDecimalValue(ListNode head) 
    {
        int n = -1;
        var curr = head;
        while (curr != null) 
        {
            n += 1;
            curr = curr.next;
        }
        
        curr = head;
        var result = 0.0;
        for (int i = n; i >= 0; i--) 
        {
            if (curr.val == 1)
            {
                result += Math.Pow(2, i);
            }
            curr = curr.next;
        }

        return (int)result;
    }
}