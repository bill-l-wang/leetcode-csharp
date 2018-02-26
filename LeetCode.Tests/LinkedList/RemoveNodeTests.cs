using LeetCode.LinkedList;
using Xunit;

namespace LeetCode.Tests.LinkedList
{
    public class RemoveNodeTests
    {
        private readonly ListNode _node1 = new ListNode(1);
        private readonly ListNode _node2 = new ListNode(2);
        private readonly ListNode _node3 = new ListNode(3);
        private readonly ListNode _node4 = new ListNode(4);
        private readonly ListNode _node5 = new ListNode(5);

        [Fact]
        public void Given_a_linked_list_when_remove_then_the_nth_should_be_removed()
        {
            var head = InitNodes();

            var solution = new RemoveNode();
            var actual = solution.RemoveFromEnd(head, 2);

            Assert.Equal(_node1.Val, actual.Val);
            Assert.Equal(_node2.Val, _node1.Next.Val);
            Assert.Equal(_node3.Val, _node1.Next.Next.Val);
            Assert.Equal(_node5.Val, _node1.Next.Next.Next.Val);
        }

        private ListNode InitNodes()
        {
            _node1.Next = _node2;
            _node2.Next = _node3;
            _node3.Next = _node4;
            _node4.Next = _node5;

            return _node1;
        }
    }
}