
//Definition for singly-linked list.
public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}

public class MergeTwoSortedLists_21{
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        if(l1 == null) return l2;
        if(l2 == null) return l1;
        
        ListNode head;
        
        if(l1.val > l2.val)
        {
            head = l2;
            head.next = MergeTwoLists(l1, l2.next);
        }
        else
        {
            head = l1;
            head.next = MergeTwoLists(l1.next, l2);
        }
        
        return head;
    }
}