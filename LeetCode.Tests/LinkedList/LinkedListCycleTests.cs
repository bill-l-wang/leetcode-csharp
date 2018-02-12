using LeetCode.LinkedList;
using Xunit;

namespace LeetCode.Tests.LinkedList
{
    public class LinkedListCycleTests
    {
        private readonly ListNode _node1 = new ListNode(1);
        private readonly ListNode _node2 = new ListNode(2);
        private readonly ListNode _node3 = new ListNode(3);
        private readonly ListNode _node4 = new ListNode(4);

        [Fact]
        public void Given_an_empty_node_when_check_hasCycle_then_should_return_not_has_cycle()
        {
            var linkedListCycle = new LinkedListCycle();
            var result = linkedListCycle.HasCycle(null);
            Assert.False(result);
        }

        [Fact]
        public void Given_an_cycle_list_when_check_hasCycle_then_should_return_has_cycle()
        {
            CycleNodes();
            var linkedListCycle = new LinkedListCycle();
            var result = linkedListCycle.HasCycle(_node1);
            Assert.True(result);
        }

        [Fact]
        public void Given_an_acyclic_list_when_check_has_cycle_then_should_return_not_has_cycle()
        {
            CycleNodes();
            _node4.Next = null;

            var linkedListCycle = new LinkedListCycle();
            var result = linkedListCycle.HasCycle(_node1);
            Assert.False(result);
        }

        private void CycleNodes()
        {
            _node1.Next = _node2;
            _node2.Next = _node3;
            _node3.Next = _node4;
            _node4.Next = _node1;
        }
    }
}
