namespace LeetCode.Practice.Tests
{
    public class LinkedListCycleTests
    {

        /*
         Input: head = [3,2,0,-4], pos = 1
         Output: true
         Explanation: There is a cycle in the linked list, where the tail connects to the 1st node (0-indexed).
        */
        [Fact]
        public void Test1()
        {
            var head = new ListNode(3);
            var pos1 = new ListNode(2);
            var pos2 = new ListNode(0);
            var pos3 = new ListNode(-4);

            head.next = pos1;
            pos1.next = pos2;
            pos2.next = pos3;
            pos3.next = pos1;

            var result = LinkedListCycle.HasCycle(head);

            Assert.True(result);
        }

        [Fact]
        public void Test2()
        {
            var head = new ListNode(3);
            var pos1 = new ListNode(2);
            var pos2 = new ListNode(0);
            var pos3 = new ListNode(-4);

            head.next = pos1;
            pos1.next = pos2;
            pos2.next = pos3;
            pos3.next = null;

            var result = LinkedListCycle.HasCycle(head);

            Assert.False(result);
        }
    }
}
