namespace LeetCode.LinkedList
{
    /// <summary>
    /// Given a linked list, remove the nth node from the end of list and return its head.
    /// Given linked list: 1->2->3->4->5, and n = 2.
    /// After removing the second node from the end, the linked list becomes 1->2->3->5.
    /// Note:
    ///Given n will always be valid.
    ///Try to do this in one pass.
    /// </summary>
    public class RemoveNode
    {
        public ListNode RemoveFromEnd(ListNode head, int index)
        {
            var dummy = new ListNode(0) {Next = head};
            var length = 0;
            var first = head;

            while (first != null)
            {
                length++;
                first = first.Next;
            }

            length -= index;
            first = dummy;

            while (length > 0)
            {
                length--;
                first = first.Next;
            }

            first.Next = first.Next.Next;
            return dummy.Next;
        }
    }
}
