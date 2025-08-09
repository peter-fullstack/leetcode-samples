namespace LeetCode.Practice.Tests
{
    public class LinkedListReversedTests
    {

        /*
         Input: head = [3,2,0,-4], pos = 1
         Output: true
         Explanation: There is a cycle in the linked list, where the tail connects to the 1st node (0-indexed).
        */
        [Fact]
        public void Test1()
        {
            var head = new ListNode(1);
            var pos1 = new ListNode(2);
            var pos2 = new ListNode(3);
            var pos3 = new ListNode(4);
            var pos4 = new ListNode(5);

            head.next = pos1;
            pos1.next = pos2;
            pos2.next = pos3;
            pos3.next = pos4;

            var newHead = LinkedListReverse.ReverseList(head);

            Assert.Equal(5, newHead?.val);
            Assert.Equal(4, newHead?.next?.val);
            Assert.Equal(3, newHead?.next?.next?.val);
            Assert.Equal(2, newHead?.next?.next?.next?.val);
            Assert.Equal(1, newHead?.next?.next?.next?.next?.val);

            Assert.Null(newHead?.next?.next?.next?.next?.next);
        }
    }
}
