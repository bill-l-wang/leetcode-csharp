using LeetCode.LinkedList;
using Xunit;

namespace LeetCode.Tests.LinkedList
{
    public class SwapNodesInPairsTests
    {
        private readonly ListNode _node1 = new ListNode(1);
        private readonly ListNode _node2 = new ListNode(2);
        private readonly ListNode _node3 = new ListNode(3);
        private readonly ListNode _node4 = new ListNode(4);

        [Fact]
        public void Given_an_list_when_swap_then_should_swaped_in_pairs()
        {
            var head = InitNodeHead();
            var swapNodes = new SwapNodes();
            var result = swapNodes.SwapNodesInPairs(head);

            Assert.Equal(2, result.Val);
            Assert.Equal(1, result.Next.Val);
            Assert.Equal(4, result.Next.Next.Val);
            Assert.Equal(3, result.Next.Next.Next.Val);
        }

        public ListNode InitNodeHead()
        {
            _node1.Next = _node2;
            _node2.Next = _node3;
            _node3.Next = _node4;

            return _node1;
        }
    }
}
