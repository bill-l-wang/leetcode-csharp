using System.Collections.Generic;

namespace LeetCode.LinkedList
{
    public class LinkedListCycle
    {
        public bool HasCycle(ListNode head)
        {
            if (head == null)
                return false;

            var nodes = new HashSet<ListNode>();
            while (head != null)
            {
                if (nodes.Contains(head))
                    return true;

                nodes.Add(head);
                head = head.Next;
            }
            return false;
        }
    }
}
