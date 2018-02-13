namespace LeetCode.LinkedList
{
    /// <summary>
    /// https://leetcode.com/problems/swap-nodes-in-pairs/description/
    /// Given a linked list, swap every two adjacent nodes and return its head.
    /// For example,
    /// Given 1->2->3->4, you should return the list as 2->1->4->3.
    /// Your algorithm should use only constant space.You may not modify the values in the list, only nodes itself can be changed.
    /// </summary>
    public class SwapNodes
    {
        public ListNode SwapNodesInPairs(ListNode head)
        {
            if (head?.Next == null)
                return head;

            var tempHead = head;
            var newHead = head.Next;
            while (tempHead?.Next != null)
            {
                var tmp = tempHead;

                tempHead = tempHead.Next;
                tmp.Next = tempHead.Next;
                tempHead.Next = tmp;
                tempHead = tmp.Next;

                if (tempHead?.Next != null)
                    tmp.Next = tempHead.Next;
            }

            return newHead;
        }
    }
}
