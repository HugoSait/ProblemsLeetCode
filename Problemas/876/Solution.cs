/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode MiddleNode(ListNode head) {
        ListNode Count;
        int i = 0;
        int j = 0;
        
        Count = head;
        
        while(Count != null){
            Count = Count.next;
            i++;
        }
        
        Count = head;
        while(j<(i/2)){
            Count = Count.next;
            j++;
        }
        
        return Count;
    }
}