namespace LeetCode.Practice
{
    public class LinkedListCycle
    {
        /*
         The Fast & Slow Pointers (Tortoise and Hare) pattern is used to detect cycles in linked lists and other similar structures.
        Sample Problem:
        Detect if a linked list has a cycle.

        Explanation:
        Initialize two pointers, one moving one step at a time (slow) and the other moving two steps at a time (fast).

        If there is a cycle, the fast pointer will eventually meet the slow pointer.

        If the fast pointer reaches the end of the list, there is no cycle.
        */


        public static bool HasCycle(ListNode head)
        {
            var keepGoing = true;

            int fastPointer = 1;

            var currentSlow = head;
            var currentFast = head;

            while (keepGoing)
            {
                currentSlow = currentSlow?.next;

                for (int i = 0; i <= fastPointer; i++)
                {
                    currentFast = currentFast?.next;

                    if(currentFast == null)
                    {
                        return false;
                    }

                    if (i == fastPointer)
                    {
                        if (currentSlow?.val == currentFast?.val)
                        {
                            return true;
                        }
                    }
                }

                fastPointer += 2;
            }

            return false;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode? next;
    
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }
}
