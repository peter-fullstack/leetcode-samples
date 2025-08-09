namespace LeetCode.Practice
{
    using System.Collections.Generic;

    public class LinkedListReverse
    {
        /*
        Given the head of a singly linked list, reverse the list, and return the reversed list.
        */


        public static ListNode? ReverseList(ListNode head)
        {
            var stack = new Stack<ListNode>();
         
            var current = head;
            while (current != null)
            {
                stack.Push(current);
                current = current.next;
            }

            ListNode? currentReversed = null;
            ListNode? newHead = null;

            if (stack.Count > 0)
            {
                currentReversed = stack.Pop();
                newHead = currentReversed;
                while (stack.Count > 0)
                {
                    if (currentReversed != null)
                    {
                        currentReversed.next = stack.Pop();
                        currentReversed = currentReversed?.next;
                    }
                    if (currentReversed != null)
                    { 
                        currentReversed.next = null;
                    }
                }
            }

            return newHead;
        }
    }
}
